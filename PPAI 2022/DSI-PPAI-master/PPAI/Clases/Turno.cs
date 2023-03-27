using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class Turno
    {
        #region Atributos
        private int id_turno;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private List<CambioEstadoTurno> cambiosDeEstados;
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public DateTime getFechaHoraInicio() { return fechaHoraInicio; }
        public void setFechaHoraInicio(DateTime fechaHoraInicio) { this.fechaHoraInicio = fechaHoraInicio; }
        public DateTime getFechaHoraFin() { return fechaHoraFin; }
        public void setFechaHoraFin(DateTime fechaHoraFin) { this.fechaHoraFin = fechaHoraFin; }
        public int getIdTurno() { return id_turno; }
        public void setIdTurno(int idTurno) { this.id_turno = idTurno; }
        public void setCambioEstadosTurno(List<CambioEstadoTurno> cambioEstados) { this.cambiosDeEstados = cambioEstados; }
        public List<CambioEstadoTurno> getcambioEstadoTurnos() { return cambiosDeEstados; }
        #endregion

        #region Constructor
        public Turno(int id,DateTime fechaHoraInicio, DateTime fechaHoraFin)
        {
            this.id_turno = id;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.cambiosDeEstados = new List<CambioEstadoTurno>();
        }

        #endregion

        #region Metodos
        
        //Indica si la fecha del turno es mayor a la fecha pasada por parametro
        public bool esPosteriorFecha(DateTime fecha) { return fechaHoraInicio.Date >= fecha; }

        //Retorna un booleano indicando si el turno es reservable
        public bool esReservable() { return buscarUltimoCambioEstadoT().getEstado().getEsReservable(); }

        //Retorna el ultimo cambio de estado del turno
        public CambioEstadoTurno buscarUltimoCambioEstadoT()
        {
            foreach (CambioEstadoTurno cambioEstado in cambiosDeEstados)
            {
                if (cambioEstado.sosUltimo()) return cambioEstado;
            }
            return null;
        }

        //Metodo que realiza la reserva de un turno
        public void reservar(DateTime fechaActual) 
        {
            var estadoActual = buscarUltimoCambioEstadoT().getEstado();
            estadoActual.reservar(this, fechaActual);
        }

        //Metodo que devuelve los datos del Turno
        public List<String> mostrarDatos() 
        {
            List<String> datos = new List<string>();
            datos.Add(fechaHoraInicio.Month.ToString());
            datos.Add(fechaHoraInicio.Day.ToString());
            datos.Add(buscarUltimoCambioEstadoT().mostrarEstado());
            datos.Add(fechaHoraInicio.Hour.ToString());
            datos.Add(fechaHoraInicio.Minute.ToString());

            return datos;
        }

        //Agrega un nuevo cambio de estado al Turno
        public void nuevoCambioEstado(CambioEstadoTurno nuevoCambio) { cambiosDeEstados.Add(nuevoCambio); }

        #endregion
    }
}
