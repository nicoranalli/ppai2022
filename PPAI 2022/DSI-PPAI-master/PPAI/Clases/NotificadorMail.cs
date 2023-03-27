using System.IO;
using System;
using System.Net.Mail;
using System.Collections.Generic;

namespace PPAI.Clases
{
    public class NotificadorMail : Notificador
    {

        #region Atributos

        const string UsuarioMail = "ppai.reservar.turno@gmail.com";
        const string ClaveMail = "tuckasxqvnbrxplt";

        #endregion

        #region Constructor

        public NotificadorMail() {}

        #endregion

        #region Metodos

        //Metodo que realiza el envio del mail 
        public void Notificar(List<string> destinatario,List<String> datos)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(UsuarioMail);
            mail.To.Add(destinatario[0]);
            mail.Subject = "Recurso Tecnológico Reservado";
            mail.IsBodyHtml = true;
            mail.Body = PopulateBody(datos);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(UsuarioMail, ClaveMail);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        ///Metodo de soporte para el envio del mail
        private string PopulateBody(List<String> datos)
        {
            string body = string.Empty;
            string path = Path.GetFullPath(@"..\..\");
            string realPath = Path.Combine(path, @"Resources/emailLight.html");
            string recursoNumero = datos[1];
            string recursoMod = datos[3];
            string str_fecha = datos[5];

            using (StreamReader reader = new StreamReader(realPath))
            {
                body = reader.ReadToEnd();
            }

            body = body.Replace("{Mod}", recursoMod);
            body = body.Replace("{Fecha}", str_fecha);
            body = body.Replace("{N}", recursoNumero);
            return body;
        }

        #endregion
    }
}
