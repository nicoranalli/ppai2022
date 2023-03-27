using PPAI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace PPAI.Repositorio
{
    public class AsignacionCientificoRepositorio
    {
        #region Metodos

        //Metodo que se encarga de crear los objetos obteniendolos de la base de datos
        public List<AsignacionCientifico> obtenerAsignaciones(int centro) 
        {
            AsignacionCientifico asignacion;

            var cientificos = new List<AsignacionCientifico>();

            var sql = $"SELECT a.fechaDesde, a.fechaHasta,a.id_asignacion_cientifico,p.legajo FROM AsignacionCientificoDelCI a LEFT JOIN PersonalCientifico p ON a.legajo = p.legajo WHERE a.numero_resolucion_creacion = {centro}";
            var tabla = ConexionBD.GetConexion().ConsultaSQL(sql);

            foreach (DataRow fila in tabla.Rows) 
            {
                var fechaDesde = DateTime.Parse(fila["fechaDesde"].ToString());
                var id_asignacion = int.Parse(fila["id_asignacion_cientifico"].ToString());
                var cientifico = new PersonalCientifico(int.Parse(fila["legajo"].ToString()));

                if (!string.IsNullOrEmpty(fila["fechaHasta"].ToString())) 
                { 
                    var fechaHasta = DateTime.Parse(fila["fechaHasta"].ToString());
                    asignacion = new AsignacionCientifico(id_asignacion,fechaDesde,fechaHasta,cientifico);
                }
                else 
                {
                    asignacion = new AsignacionCientifico(id_asignacion,fechaDesde,cientifico); ;
                }

                
                cientificos.Add(asignacion);
            }

            return cientificos;
        }

        #endregion
    }
}
