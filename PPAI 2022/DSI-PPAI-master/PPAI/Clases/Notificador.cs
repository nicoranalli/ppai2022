using System.Collections.Generic;

namespace PPAI.Clases
{
    public interface Notificador
    {
        #region Constructor
        void Notificar(List<string> destinatario,List<string> datos);

        #endregion
    }
}
