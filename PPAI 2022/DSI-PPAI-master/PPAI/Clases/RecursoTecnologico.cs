using System.Collections.Generic;
using System;

namespace PPAI.Clases
{
    public class RecursoTecnologico
    {
        #region Atributos
        private int numero;
        private string imagen;
        private Modelo modelo;
        private TipoRecursoTecnologico tipo;
        private List<CambioEstadoRT> cambioEstadoRTs;
        private List<Turno> turnos;
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public string getImagen() { return imagen; }
        public void setImagen(string imagen) { this.imagen = imagen; }
        public List<Turno> getTurnos() { return turnos; }
        public void setTurnos(List<Turno> turnos) { this.turnos = turnos;}
        public Modelo getModelo() { return modelo; }
        public void setModelo(Modelo modelo) { this.modelo = modelo; }
        public TipoRecursoTecnologico getTipo() { return tipo; }
        public void setTipo(TipoRecursoTecnologico tipo) { this.tipo = tipo; }
        public int getNumero() { return numero; }
        public void setNumero(int numero) { this.numero = numero; }
        public void setCambiosEstados(List<CambioEstadoRT> cambioEstadoRTs) { this.cambioEstadoRTs = cambioEstadoRTs; }
        public List<CambioEstadoRT> getCambioEstadoRTs() { return cambioEstadoRTs; }
        #endregion

        #region Constructor
        public RecursoTecnologico(int numeroRT, Modelo modelo, TipoRecursoTecnologico tipo)
        {
            this.numero = numeroRT;
            this.tipo = tipo;
            this.modelo = modelo;
            this.cambioEstadoRTs = new List<CambioEstadoRT>();
            this.turnos = new List<Turno>();
            //this.imagen = imagen;
        }

        #endregion

        #region Metodos

        //Metodo que indica si el tipo recurso es el mismo que el pasado por parametro 
        public bool esTipoSeleccionado(string seleccionado) { return tipo.getNombre() == seleccionado; }
        
        //Metodo que permite conocer si el recurso se encuentra en un estado disponiible
        public bool estasDisponible() 
        {
            return buscarUltimoCambioEstadoRT().estasDisponible();
        }

        //Metodo que retorna el ultimo cambio de estado del recurso
        public CambioEstadoRT buscarUltimoCambioEstadoRT()
        {
            foreach (CambioEstadoRT cambio in cambioEstadoRTs) 
            {
                if (cambio.sosUltimo()) { return cambio; }
            }

            return null;
        }

        //Retorna una lista de strings con los datos del objeto
        public List<string> mostrarDatos(List<Marca> marcas, List<CentroInvestigacion> centros) 
        {
            var datos = new List<string>();

            datos.Add(mostrarCI(centros).getNombre());
            datos.Add(numero.ToString());
            datos.Add(modelo.mostrarMarca(marcas));
            datos.Add(modelo.getNombre());
            datos.Add(buscarUltimoCambioEstadoRT().mostrarEstado());

            return datos;
        }

        //Metodo que permite conocer el centro de investigacion del recurso
        public CentroInvestigacion mostrarCI(List<CentroInvestigacion> centros) 
        {
           foreach(CentroInvestigacion centro in centros) 
            {
                if (centro.esMiRecurso(this)) { return centro; }
            }
            return null;
        }

        //Permite conocer si el cientifico pasado como parametro es del mismo centro que el del recurso
        public AsignacionCientifico elCientificoEsDeMiCentro(PersonalCientifico cientifico,List<CentroInvestigacion> centros)
        {
            var centro_recurso = mostrarCI(centros);

            return  centro_recurso.esTuCientificoActual(cientifico);
        }

        //Metodo que devuelve los datos de los turnos disponibles del recurso
        public List<List<string>> mostrarTurnos(DateTime fecha)
        {
            var turnos_reservables = new List<List<string>>();
            foreach(Turno turno in turnos) { if (turno.esPosteriorFecha(fecha)) { turnos_reservables.Add(turno.mostrarDatos()); } }
            return turnos_reservables;
        }

        //Metodo que retorna la lista de turnos disponibles del recurso
        public List<Turno> obtenerTurnos() 
        {
            var lista = new List<Turno>();
            foreach (Turno turno in turnos) { if (turno.esPosteriorFecha(DateTime.Now) ) { lista.Add(turno); } }
            return lista;
        }

        //Metodo que realiza la reserva un turno del recurso
        public void reservarTurno(Turno turno,DateTime fechaActual) { turno.reservar(fechaActual); }
        #endregion
    }
}
