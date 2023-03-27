using PPAI.Clases;
using System.Collections.Generic;
using System.Data;

namespace PPAI.Repositorio
{
    public class RecursoTecnologicoRepositorio
    {
        #region Atributos

        private readonly TurnoRepositorio turnoRepositorio;
        private readonly CambioEstadoRTRepositorio cambioEstadoRTRepositorio;

        #endregion

        #region Constructor

        public RecursoTecnologicoRepositorio() 
        { 
            turnoRepositorio = new TurnoRepositorio();
            cambioEstadoRTRepositorio = new CambioEstadoRTRepositorio();
        }

        #endregion

        #region Metodos

        //Metodo que se encarga de crear los objetos obteniendolos de la base de datos
        public List<RecursoTecnologico> obtenerRecursos()
        {
            var recursos = new List<RecursoTecnologico>();

            var sql = $"SELECT r.numero, r.imagenes, t.nombre,  t.id_tipo_rt, m.nombre as modelo FROM RecursoTecnologico r " +
                $"JOIN TipoRecursoTecnologico t ON t.id_tipo_rt = r.id_tpo_rt " +
                $"JOIN Modelo m ON m.id_modelo = r.id_modelo";
            var tabla = ConexionBD.GetConexion().ConsultaSQL(sql);

            foreach (DataRow fila in tabla.Rows)
            {
                var numero = int.Parse(fila["numero"].ToString());
                var tipo = new TipoRecursoTecnologico(int.Parse(fila["id_tipo_rt"].ToString()), fila["nombre"].ToString());
                var modelo = new Modelo(fila["modelo"].ToString());

                var recurso = new RecursoTecnologico(numero, modelo, tipo);
                recursos.Add(recurso);
            }


            foreach (RecursoTecnologico recurso in recursos) 
            {
                var turnos = turnoRepositorio.obtenerTurnos(recurso.getNumero());
                var cambiosEstado = cambioEstadoRTRepositorio.obtenerCambioEstadoRT(recurso.getNumero());
                
                recurso.setCambiosEstados(cambiosEstado);
                recurso.setTurnos(turnos);
            }


            return recursos;
        }

        public List<RecursoTecnologico> obtenerRecursos(int centro)
        {
            var recursos = new List<RecursoTecnologico>();

            var sql = $"SELECT r.numero, r.imagenes, t.nombre,  t.id_tipo_rt, m.nombre FROM RecursoTecnologico r " +
                $"LEFT JOIN CambioEstadoRT c ON r.numero = c.numero " +
                $"JOIN TipoRecursoTecnologico t ON t.id_tipo_rt = r.id_tpo_rt " +
                $"JOIN Modelo m ON m.id_modelo = r.id_modelo WHERE r.numero_resolucion_creacion={centro}";
            var tabla = ConexionBD.GetConexion().ConsultaSQL(sql);

            foreach (DataRow fila in tabla.Rows)
            {
                var numero = int.Parse(fila["numero"].ToString());
                //var imagen = fila["imagenes"].ToString();
                var tipo = new TipoRecursoTecnologico(int.Parse(fila["id_tipo_rt"].ToString()), fila["nombre"].ToString());
                var modelo = new Modelo(fila["nombre"].ToString());

                var recurso = new RecursoTecnologico(numero, modelo, tipo);
                recursos.Add(recurso);
            }


            foreach (RecursoTecnologico recurso in recursos)
            {
                var turnos = turnoRepositorio.obtenerTurnos(recurso.getNumero());
                var cambiosEstado = cambioEstadoRTRepositorio.obtenerCambioEstadoRT(recurso.getNumero());

                recurso.setCambiosEstados(cambiosEstado);
                recurso.setTurnos(turnos);
            }


            return recursos;
        }

        #endregion
    }
}
