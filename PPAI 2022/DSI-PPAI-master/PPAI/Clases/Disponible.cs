using System;

namespace PPAI.Clases
{
    public class Disponible:Estado
    {
        #region Constructor
        public Disponible(int id_estado,string nombre, string descripcion,string ambito ,bool esReservable, bool esCancelable) : base(id_estado,nombre, descripcion, ambito,esReservable, esCancelable) { }

        #endregion

        #region Metodos
        
        //Metodo polimorfico que realiza la reserva del turno
        public override void reservar(Turno turno, DateTime fechaActual)
        {
            turno.buscarUltimoCambioEstadoT().setFechaHoraHasta(fechaActual);
            Estado estado = new Reservado(2,"Reservado","Estado en el que el turno ya esta ocupado","Turno",false,true);
            CambioEstadoTurno nuevoCambio = new CambioEstadoTurno(fechaActual, estado);
            turno.nuevoCambioEstado(nuevoCambio);
        }
        #endregion
    }
}
