using System;

namespace PPAI.Clases
{
    public class CambioEstadoRT
    {
        #region Atributos
        private DateTime fechaHoraDesde;
        private DateTime? fechaHoraHasta;
        private Estado estado;
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public DateTime getHoraDesde() { return fechaHoraDesde; }
        public DateTime? getHoraHasta() { return fechaHoraHasta; }
        public void setFechaHoraDesde(DateTime fechaHoraDesde) { this.fechaHoraDesde = fechaHoraDesde; }
        public void setFechaHoraHasta(DateTime fechaHoraHasta) { this.fechaHoraHasta = fechaHoraHasta; }
        #endregion

        #region Constructor
        public CambioEstadoRT(DateTime fechaHoraDesde, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.estado = estado;
        }

        public CambioEstadoRT(DateTime fechaHoraDesde, DateTime? fechaHoraHasta,Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;
        }

        #endregion

        #region Metodos

        //Regresa un booleano que permite saber si es el ultimo de cambio de estado
        public bool sosUltimo() { return fechaHoraHasta == null; }

        //Regresa un booleano indicando si el estado es un estado reservable
        public bool estasDisponible() { return estado.getEsReservable(); }

        //Devuelve el nombre del estado
        public string mostrarEstado() { return estado.getNombre(); }
        
        #endregion
    }
}
