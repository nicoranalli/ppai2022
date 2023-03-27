using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class DisponibleR : Estado
    {

        #region Constructor
        public DisponibleR(int id_estado, string nombre, string descripcion, string ambito, bool esReservable, bool esCancelable) : base(id_estado, nombre, descripcion, ambito, esReservable, esCancelable) { }

        #endregion

        #region Metodos
        
        //Metodo polimorfico heredado de la clase Estado
        public override void reservar(Turno turno, DateTime fechaActual) { }
        #endregion
    }
}
