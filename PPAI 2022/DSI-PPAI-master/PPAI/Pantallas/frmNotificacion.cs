using PPAI.Properties;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace PPAI
{
    public partial class frmNotificacion : Form
    {
        private static readonly List<frmNotificacion> NotificacionesAbiertas = new List<frmNotificacion>();

        public frmNotificacion()
        { }
        public frmNotificacion(String mensaje, Color bgColor, int tipo)
        {
            InitializeComponent();

            this.BackColor = bgColor;
            this.lblMensaje.Text = mensaje;
            switch (tipo)
            {
                case 1:
                    imgNotificacion.Image = Resources.success;
                    break;
                case 2:
                    imgNotificacion.Image = Resources.warning;
                    break;
                case 3:
                    imgNotificacion.Image = Resources.error;
                    break;
                case 4:
                    imgNotificacion.Image = Resources.done;
                    break;
                case 5:
                    imgNotificacion.Image = Resources.info;
                    break;
                case 6:
                    imgNotificacion.Image = Resources.cancel;
                    break;
            }
            this.Show();
        }
        public void ShowNotificacion(String mensaje, Color bgColor, int tipo)
        {
            frmNotificacion form = new frmNotificacion(mensaje, bgColor, tipo);
            form.Show();
        }
        private void Notificacion_Load(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 10;
            Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10;

            foreach (frmNotificacion FormAbierto in NotificacionesAbiertas)
            {
                FormAbierto.Top -= Height + 10;
            }

            NotificacionesAbiertas.Add(this);

            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
