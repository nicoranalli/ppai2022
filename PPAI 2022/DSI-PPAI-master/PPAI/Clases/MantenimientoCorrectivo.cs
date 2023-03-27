using System;

namespace PPAI.Clases
{
    public class MantenimientoCorrectivo : Estado
    {
        #region Constructor

        public MantenimientoCorrectivo(int id_estado, string nombre, string descripcion, string ambito, bool esReservable, bool esCancelable) : base(id_estado, nombre, descripcion, ambito, esReservable, esCancelable) { }
        #endregion

        #region Metodos
        
        //Metodo polimorifico heredado de la clase Estado
        public override void reservar(Turno turno, DateTime fechaActual) { }
        #endregion
    }
}
