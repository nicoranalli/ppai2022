using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI
{
    public partial class Principal : Form
    {
        private Guna2Button btnActivo;

        public Principal()
        {
            InitializeComponent();
        }
        public void AbrirForm(object form)
        {
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Clear();
            this.pnlPrincipal.Controls.Add(frm);
            this.pnlPrincipal.Tag = frm;
            frm.BringToFront();
            frm.Show();

        }
        private void ActivarFoco(Guna2Button btnFoco)
        {
            btnFoco.Checked = true;
            btnFoco.Cursor = DefaultCursor;
            if (btnActivo != btnFoco && btnActivo != null)
            {
                btnActivo.Checked = false;
                btnActivo.Cursor = Cursors.Hand;
            }
            btnActivo = btnFoco;
        }
        private void btnReservarTurno_Click(object sender, EventArgs e) { AbrirForm(new reservarRT()); ActivarFoco(btnReservarTurno); }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form form = new LogIn();
            form.Show();
        }
        private void btnMinimizar_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void btnCerrar_Click(object sender, EventArgs e) { Application.Exit(); }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
