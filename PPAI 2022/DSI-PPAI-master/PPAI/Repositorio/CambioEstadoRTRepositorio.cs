using PPAI.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace PPAI.Repositorio
{
    public class CambioEstadoRTRepositorio
    {
        #region Metodos

        //Metodo que se encarga de crear los objetos obteniendolos de la base de datos
        public List<CambioEstadoRT> obtenerCambioEstadoRT(int recurso) 
        {
            var cambios = new List<CambioEstadoRT>();

            var sql = $"SELECT c.fecha_hora_desde,c.fecha_hora_hasta,e.nombre,e.descripcion,e.ambito,e.es_reservable,e.es_cancelable,e.id_estado FROM CambioEstadoRT c JOIN Estado e ON c.id_estado = e.id_estado AND c.numero = {recurso}";

            var tabla = ConexionBD.GetConexion().ConsultaSQL(sql);

            foreach(DataRow fila in tabla.Rows) 
            {
                CambioEstadoRT cambio;
                
                DateTime fechaInicio = DateTime.Parse(fila["fecha_hora_desde"].ToString());

                int id_estado = int.Parse(fila["id_estado"].ToString());
                string nombre = fila["nombre"].ToString();
                string descripcion = fila["descripcion"].ToString();
                string ambito = fila["ambito"].ToString();
                bool esReservable = bool.Parse(fila["es_reservable"].ToString());
                bool esCancelable = bool.Parse(fila["es_cancelable"].ToString());

                var estado = obtenerEstado(id_estado,nombre, descripcion, ambito, esReservable, esCancelable);

                if (!string.IsNullOrEmpty(fila["fecha_hora_hasta"].ToString()))
                {
                    var fechaFin = DateTime.Parse(fila["fecha_hora_hasta"].ToString());
                    cambio = new CambioEstadoRT(fechaInicio, fechaFin, estado);
                }
                else 
                {
                    cambio = new CambioEstadoRT(fechaInicio,estado);
                }
                
                cambios.Add(cambio);
            }
            
            return cambios;
        }

        public Estado obtenerEstado(int id_estado,string nombre, string descripcion, string ambito, bool esReservable, bool esCancelable)
        {
            //revisar
            Estado estado = null;
            switch (nombre)
            {
                case "Disponible": estado = new DisponibleR(id_estado,nombre, descripcion, ambito, esReservable, esCancelable); break;
                case "En Mantenimiento": estado = new Mantenimiento(id_estado, nombre, descripcion, ambito, esReservable, esCancelable); break;
                case "Con Inicio de Mantenimiento Correctivo": estado = new MantenimientoCorrectivo(id_estado, nombre, descripcion, ambito, esReservable, esCancelable); break;
            }

            return estado;
        }

        #endregion
    }
}
