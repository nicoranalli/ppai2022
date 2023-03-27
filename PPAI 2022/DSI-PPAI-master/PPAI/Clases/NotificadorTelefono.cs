using System.Collections.Generic;

namespace PPAI.Clases
{
    public class NotificadorTelefono : Notificador
    {
        #region Constructor

        public NotificadorTelefono() { }

        #endregion

        #region Metodos

        //Metodo que realiza el envio de la notificacion por WSP
        public void Notificar(List<string> destinatario,List<string> datos) { var numero = destinatario[1]; }

        #endregion
    }
}
