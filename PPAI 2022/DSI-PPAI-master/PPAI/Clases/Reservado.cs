using System;

namespace PPAI.Clases
{
    public class Reservado : Estado
    {
        #region Constructos

        public Reservado(int id_estado,string nombre,string descripcion,string ambito,bool esReservable,bool esCancelable) : base(id_estado,nombre,descripcion,ambito,esReservable,esCancelable) { }

        #endregion

        #region Metodos

        //Metodo polimorfico heredado de Estado
        public override void reservar(Turno turno, DateTime fechaActual) {}

        #endregion
    }
}
