using System;
using System.Drawing;
using System.Windows.Forms;
using PPAI.Clases;
using System.IO;
using System.Collections.Generic;

namespace PPAI
{
    public partial class Confirmar : Form
    {
        public Confirmar() { InitializeComponent(); }
        private void Confirmar_Load(object sender, EventArgs e) 
        {   

            List<String> datos = Gestor.GetGestor().datosResumen();

            txtCentro.Text = datos[0];
            txtNumero.Text = datos[1];
            txtModelo.Text = datos[2];
            txtMarca.Text = datos[3];
            txtEstado.Text = datos[4];
            txtFecha.Text = datos[5];
            //string path = Path.GetFullPath(@"..\..\");
            //string imagen = _gestor.rtSeleccionado.getImagen();
            //string realPath = Path.Combine(path, @"Resources/", imagen);
            //imagenRecurso.Image = Image.FromFile(realPath);
            //imagenRecurso.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
        #region Eventos
        private void btnReservarRecurso_Click(object sender, EventArgs e) { tomarConfirmacion(); }
        
        private void btnCancelar_Click(object sender, EventArgs e) 
        {
            //Gestor.GetGestor().recursoSeleccionado = null;
            //Gestor.GetGestor().turnoSeleccionado = null;
            this.Close(); 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Gestor.GetGestor().recursoSeleccionado = null;
            Gestor.GetGestor().turnoSeleccionado = null;
            this.Close();
        }
        #endregion

        #region Metodos
        private void tomarConfirmacion()
        {
            Gestor.GetGestor().obtenerFechaActual();

            bool resultado_reserva = Gestor.GetGestor().generarReservaTurnoRt();

            if (resultado_reserva) 
            {
                new frmNotificacion("Turno reservado con exito!", Color.FromArgb(34, 139, 34), 1);
            }
            else 
            {
                new frmNotificacion("No se pudo realizar la reserva", Color.FromArgb(220, 20, 60), 3);
            };

            Gestor.GetGestor().generarNotificacion(cbMail.Checked, cbWhatsApp.Checked);
            this.Close();
        }
        #endregion
    }
}
