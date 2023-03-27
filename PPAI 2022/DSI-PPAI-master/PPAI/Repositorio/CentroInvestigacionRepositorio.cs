using PPAI.Clases;
using System.Collections.Generic;
using System.Data;

namespace PPAI.Repositorio
{
    public class CentroInvestigacionRepositorio
    {
        #region Atributos

        private readonly RecursoTecnologicoRepositorio recursoTecnologicoRepositorio;
        private readonly AsignacionCientificoRepositorio asignacionCientificoRepositorio;

        #endregion

        #region Constructor
        
        public CentroInvestigacionRepositorio() 
        {
            recursoTecnologicoRepositorio = new RecursoTecnologicoRepositorio();
            asignacionCientificoRepositorio = new AsignacionCientificoRepositorio();
        }

        #endregion

        #region Metodos

        //Metodo que se encarga de crear los objetos obteniendolos de la base de datos
        public List<CentroInvestigacion> obtenerCentros() 
        { 
            var centros = new List<CentroInvestigacion>();

            var sql = $"SELECT nombre,numero_resolucion_creacion ,tiempo_antelacion_reserva FROM CentroDeInvestigacion";
            var tabla = ConexionBD.GetConexion().ConsultaSQL(sql);

            foreach(DataRow fila in tabla.Rows) 
            { 
                var nombre = fila["nombre"].ToString();
                var resolucion = int.Parse(fila["numero_resolucion_creacion"].ToString());
                var tiempo_antelacion = int.Parse(fila["tiempo_antelacion_reserva"].ToString());
                var centro = new CentroInvestigacion(resolucion,nombre,tiempo_antelacion);
                centros.Add(centro);
            }

            foreach(CentroInvestigacion centro in centros) 
            {
                var recursos = recursoTecnologicoRepositorio.obtenerRecursos(centro.getNumeroResolucion());
                var asignaciones = asignacionCientificoRepositorio.obtenerAsignaciones(centro.getNumeroResolucion());

                centro.setRecursos(recursos);
                centro.setAsignaciones(asignaciones);
            }

            return centros;
        
        }

        #endregion
    }
}
