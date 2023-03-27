using System;

namespace PPAI.Clases
{
    public class ReservaPendienteDeConfirmacion : Estado
    {
        #region Constructor
        
        public ReservaPendienteDeConfirmacion(int id_estado, string nombre, string descripcion, string ambito, bool esReservable, bool esCancelable) : base(id_estado, nombre, descripcion, ambito, esReservable, esCancelable) { }

        #endregion

        #region Metodos

        //Metodo polimorfico heredado desde Estado
        public override void reservar(Turno turno, DateTime fechaActual) { }

        #endregion
    }
}
