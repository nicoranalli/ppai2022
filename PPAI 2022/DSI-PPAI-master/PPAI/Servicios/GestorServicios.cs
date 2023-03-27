using System;
using System.Collections.Generic;
using System.Drawing;
using PPAI.Clases;
using PPAI.Repositorio;

namespace PPAI.Servicios
{
    public class GestorServicios
    {
        #region Atributos
        private readonly RecursoTecnologicoServicio recursoTecnologicoServicio;
        private readonly TipoRecursoTecnologicoServicio tipoRecursoTecnologicoServicio;
        private readonly CentroInvestigacionServicio centroInvestigacionServicio;
        private readonly MarcaServicios marcaServicios;
        private readonly UsuarioServicio usuarioServicio;
        private readonly PersonalCientificoServicios personalCientificoServicio;

        #endregion

        #region Constructor
        
        public GestorServicios() 
        {
            recursoTecnologicoServicio = new RecursoTecnologicoServicio();
            tipoRecursoTecnologicoServicio = new TipoRecursoTecnologicoServicio();
            marcaServicios = new MarcaServicios();
            centroInvestigacionServicio = new CentroInvestigacionServicio();
            usuarioServicio = new UsuarioServicio();
            personalCientificoServicio = new PersonalCientificoServicios();
        }

        #endregion

        #region Metodos

        //Metodo que se encarga de retorna una lista de recursos obtenida desde la base de datos
        public List<RecursoTecnologico> obtenerRecursos() { return recursoTecnologicoServicio.obtenerRecursos(); }


        //Metodo que se encarga de retorna una lista de tipos de recursos obtenida desde la base de datos
        public List<TipoRecursoTecnologico> obtenerTipos() { return tipoRecursoTecnologicoServicio.obtenerTipos(); }


        //Metodo que se encarga de retorna una lista de usuarios obtenida desde la base de datos
        public List<Usuario> obtenerUsuarios() { return usuarioServicio.obtenerUsuarios(); }


        //Metodo que se encarga de retorna una lista de cientificos obtenida desde la base de datos
        public List<PersonalCientifico> obtenerCientificos() { return personalCientificoServicio.obtenerCientificos(); }


        //Metodo que se encarga de retorna una lista de centros obtenida desde la base de datos
        public List<CentroInvestigacion> obtenerCentros() { return centroInvestigacionServicio.obtenerCentros(); }


        //Metodo que se encarga de retorna una lista de marcas obtenida desde la base de datos
        public List<Marca> obtenerMarcas() { return marcaServicios.obtenerMarcas(); }

        //Metodo que se encarga de guardar la reserva en la base de datos
        public bool guardarReserva(int id_asignacion,int id_turno,DateTime fechaActual)
        {
            var fecha_string = fechaActual.ToString("yyyy-MM-ddTHH:mm:ss");

            using (var tx = ConexionBD.GetConexion().IniciarTransaccion())
            {
                try
                {
                    var sql = $"UPDATE Turno SET id_asignacion_cientifico = {id_asignacion} WHERE id_turno = {id_turno}";
                    ConexionBD.GetConexion().EjecutarSQL(sql);
                    sql = $"UPDATE CambioEstadoTurno SET fecha_hora_hasta = '{fecha_string}' WHERE id_turno = {id_turno} AND fecha_hora_hasta IS NULL";
                    ConexionBD.GetConexion().EjecutarSQL(sql);
                    sql = $"INSERT INTO CambioEstadoTurno(fecha_hora_desde,fecha_hora_hasta,id_turno,id_estado) VALUES('{fecha_string}',NULL,{id_turno},2)";
                    ConexionBD.GetConexion().EjecutarSQL(sql);
                    tx.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return false;
                }
                finally { ConexionBD.GetConexion().CloseConnection(); }
            }
        }
        #endregion
    }
}
