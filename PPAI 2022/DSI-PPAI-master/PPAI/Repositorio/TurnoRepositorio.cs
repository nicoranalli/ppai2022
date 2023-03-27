using PPAI.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace PPAI.Repositorio
{
    public class TurnoRepositorio
    {
        #region Atributos

        private readonly CambioEstadoTurnoRepositorio cambioEstadoTurnoRepositorio;

        #endregion

        #region Constructor
        
        public TurnoRepositorio() { cambioEstadoTurnoRepositorio = new CambioEstadoTurnoRepositorio(); }

        #endregion

        #region Metodos

        //Metodo que se encarga de crear los objetos obteniendolos de la base de datos
        public List<Turno> obtenerTurnos(int recurso) 
        { 
            var turnos = new List<Turno>();

            var sql = $"SELECT id_turno,fecha_hora_inicio,fecha_hora_fin FROM Turno WHERE numero = {recurso}";
            var tabla = ConexionBD.GetConexion().ConsultaSQL(sql);

            foreach (DataRow fila in tabla.Rows) 
            {
                var id = int.Parse(fila["id_turno"].ToString());
                DateTime fechaInicio = DateTime.Parse(fila["fecha_hora_inicio"].ToString());
                DateTime fechaFin = DateTime.Parse(fila["fecha_hora_fin"].ToString());

                var turno = new Turno(id,fechaInicio,fechaFin);
                turnos.Add(turno);
            }

            foreach (Turno turno in turnos) 
            {
                var cambiosEstados = cambioEstadoTurnoRepositorio.obtenerCambiosEstadosTurno(turno.getIdTurno());
                turno.setCambioEstadosTurno(cambiosEstados);
            }

            return turnos;
        }

        #endregion
    }
}
