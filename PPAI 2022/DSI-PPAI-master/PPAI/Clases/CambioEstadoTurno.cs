using System;

namespace PPAI.Clases
{
    public class CambioEstadoTurno
    {
        #region Atributos
        private DateTime fechaHoraDesde;
        private DateTime? fechaHoraHasta;
        private Estado estado;
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public DateTime getFechaHoraDesde() { return fechaHoraDesde; }
        public void setFechaHoraDesde(DateTime fechaHoraDesde) { this.fechaHoraDesde = fechaHoraDesde; }
        public DateTime? getFechaHoraHasta() { return fechaHoraHasta; }
        public void setFechaHoraHasta(DateTime fechaHoraHasta) { this.fechaHoraHasta = fechaHoraHasta; }
        public Estado getEstado() { return estado; }
        #endregion

        #region Constructor
        public CambioEstadoTurno(DateTime fechaHoraDesde, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.estado = estado;
        }
        public CambioEstadoTurno(DateTime fechaHoraDesde,DateTime? fechaHoraHasta ,Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta= fechaHoraHasta;
            this.estado = estado;
        }

        #endregion

        #region Metodos

        //Metodo que permite reconococer si el cambio de estado es el ultimo
        public bool sosUltimo() { return fechaHoraHasta == null; }

        //Regresa el nombre del estado
        public string mostrarEstado() { return estado.getNombre(); }

        #endregion
    }
}
