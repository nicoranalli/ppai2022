using PPAI.Servicios;
using System.Collections.Generic;
using System;
using PPAI.Repositorio;
using System.Drawing;

namespace PPAI.Clases
{
    public class Gestor
    {
        #region Atributos
        private static Gestor instance = new Gestor();
        private readonly GestorServicios servicios;

        public List<RecursoTecnologico> recursos;
        public List<PersonalCientifico> cientificos;
        public List<Usuario> usuarios;
        public List<Marca> marcas;
        public List<CentroInvestigacion> centros;
        public List<TipoRecursoTecnologico> tipos;

        public Sesion sesionLogueada;
        public RecursoTecnologico recursoSeleccionado;
        public Turno turnoSeleccionado;
        public PersonalCientifico cientificoSesion;
        public AsignacionCientifico asigncacionLogueada;
        public DateTime fechaActual;
        public List<Notificador> observadores = new List<Notificador>();

        #endregion

        #region Constructor

        private Gestor()
        {
            servicios = new GestorServicios();
            obtenerDatos();
        }

        #endregion

        #region Accesor - Metodos que permiten acceder a los atributos del objeto
        
        public static Gestor GetGestor()
        {
            if (instance == null) instance = new Gestor();
            return instance;
        }

        #endregion

        #region Metodos

        //Metodo que setea en el gestor todos los datos necesarios en el programa
        public void obtenerDatos()
        {
            recursos = servicios.obtenerRecursos();
            tipos = servicios.obtenerTipos();
            usuarios = servicios.obtenerUsuarios();
            cientificos = servicios.obtenerCientificos();
            centros = servicios.obtenerCentros();
            marcas = servicios.obtenerMarcas();
        }

        //Metodo retorna un booleano si el usuario que se recibe es un usuario valido
        public bool verificarUsuario(Usuario user)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (user.getUsuario() == usuario.getUsuario() && user.getClave() == usuario.getClave()) return true;
            }

            return false;
        }


        //Metodo que obtiene el listado de los tipos de recurso
        public List<string> opcionReservaTurno()
        {
            var tipos_nombre = new List<string>();

            foreach (TipoRecursoTecnologico tipo in tipos)
            {
                tipos_nombre.Add(tipo.getNombre());
            };

            return tipos_nombre;
        }


        //Metodo que retorna una lista con los datos de los recursos de acuerdo al tipo parametrizado
        public List<List<string>> tomarSeleccionTipoRT(string tipo)
        {
            return buscarRTActivoTipoRT(tipo);
        }

        //Metodo que se encarga de crear la lista de los recursos de acuerdo al tipo parametrizado
        public List<List<string>> buscarRTActivoTipoRT(string tipo)
        {
            var recursos_lista = new List<List<string>>();

            if (tipo == "TODOS")
            {
                foreach (RecursoTecnologico recurso in recursos)
                {
                    if (recurso.estasDisponible()) recursos_lista.Add(recurso.mostrarDatos(marcas, centros));
                }
                return recursos_lista;
            }
            
            foreach (RecursoTecnologico recurso in recursos)
            {
                if (recurso.esTipoSeleccionado(tipo) && recurso.estasDisponible()) recursos_lista.Add(recurso.mostrarDatos(marcas, centros));
            }
            return recursos_lista;
        }
        
        //Metodo que setea el recurso seleccionado
        public void tomarSeleccionRT(string id)
        {
            foreach (RecursoTecnologico recurso in recursos)
            {
                if (recurso.getNumero().ToString() == id)
                {
                    recursoSeleccionado = recurso;
                    break;
                }
            }
        }

        //Retorna que setea la asignacion logueado
        public bool verificarCICientificoLog()
        {
            foreach (PersonalCientifico cientifico in cientificos)
            {
                if (sesionLogueada.obtenerCientifoLog(cientifico) != null) cientificoSesion = sesionLogueada.obtenerCientifoLog(cientifico);
            }

            asigncacionLogueada = recursoSeleccionado.elCientificoEsDeMiCentro(cientificoSesion, centros);

            return asigncacionLogueada != null ;
        }

        //Metodo que obtiene la fecha actual
        public void obtenerFechaActual() { fechaActual = DateTime.Now; }

        //Retorna un lista con los datos de turnos reservables
        public List<List<string>> obtenerTurnosReservables(DateTime fecha) { return recursoSeleccionado.mostrarTurnos(fecha); }

        //Metodo que se encarga de tomar la seleccion del turno
        public bool tomarSeleccionTurno(DateTime fecha) 
        {
            var valor = false;
            foreach (Turno turno in recursoSeleccionado.obtenerTurnos()) 
            {
                if (turno.getFechaHoraInicio() == fecha) 
                {
                    if (turno.esReservable())
                    {
                        turnoSeleccionado = turno;
                        valor = true;
                        return valor;
                    }
                    else
                    {
                        new frmNotificacion("Seleccione un turno Disponible para reservar", Color.FromArgb(255, 0, 0), 3);
                        return valor;
                    }
                }
            }
            return valor;
        }

        //Metodo que se encarga de iniciar la reserva del turno
        public bool generarReservaTurnoRt()
        {
            recursoSeleccionado.reservarTurno(turnoSeleccionado, fechaActual);
            asigncacionLogueada.agregarTurno(turnoSeleccionado);

            return guardarReserva();
        }

        //Retorna una lista de strings con los datos de la reserva
        public List<string> datosResumen() 
        { 
            List<string> datosResumen = recursoSeleccionado.mostrarDatos(marcas, centros);
            datosResumen.Add(turnoSeleccionado.getFechaHoraInicio().ToString());
            return datosResumen;
        }

        //Metodo que se encarga de iniciar  el proceso de las notificaciones
        public void generarNotificacion(bool opcionMail, bool opcionTelefono) 
        {
            obtenerObservadores(opcionMail, opcionTelefono);

            Notificar();
        }

        //Obtiene los observadores
        public void obtenerObservadores(bool mail,bool telefono) 
        {
            if (mail) { var observadorMail = new NotificadorMail(); suscribir(observadorMail); }
            
            if (telefono) { var observadorTelefono = new NotificadorTelefono(); suscribir(observadorTelefono); }
        }

        //Metodo que se encarga de agregar un observador a la lista de observadores
        public void suscribir(Notificador observador) { observadores.Add(observador); }

        //Metodo que obtiene el mail de la asignacion logueada
        public string obtenerMailCientifico() { return cientificoSesion.getCorreoElectronicoInstitucional(); }

        //Metodo que obtiene el numero de telefono de la asignacion logueada
        public string obtenerTelefonoCientifico() { return cientificoSesion.getNumeroTelefono().ToString(); }

        //Metodo que se encarga de realizar las notificaciones
        public void Notificar()
        {
            var destinatarios = new List<string>();
            destinatarios.Add(obtenerMailCientifico());
            destinatarios.Add(obtenerTelefonoCientifico());

            foreach (Notificador observador in observadores) { observador.Notificar(destinatarios,datosResumen());}
        }

        //Metodo que delega el trabajo de guardar la reserva en la base de datos
        public bool guardarReserva() { return servicios.guardarReserva(asigncacionLogueada.getIdAsignacion(), turnoSeleccionado.getIdTurno(),fechaActual); }
        #endregion
    }
}
