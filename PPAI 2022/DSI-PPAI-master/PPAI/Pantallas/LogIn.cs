using System;
using System.Drawing;
using System.Windows.Forms;
using PPAI.Clases;

namespace PPAI
{
    public partial class LogIn : Form
    {
        public LogIn() { InitializeComponent(); Gestor.GetGestor();}
        private void btnIngresar_Click(object sender, EventArgs e) { habilitarPantalla(); }
        private void habilitarPantalla() 
        {
            var nombre = txtUsuario.Text;
            var contrasenia = txtContrasenia.Text;

            if (validarCampos(nombre, contrasenia)) return;
                
            var user = new Usuario(contrasenia, nombre);
            
            if (Gestor.GetGestor().verificarUsuario(user))
            {
                Sesion actual = new Sesion(user);
                Gestor.GetGestor().sesionLogueada = actual;
                new frmNotificacion("Logeo Exitoso", Color.FromArgb(34, 139, 34), 1);
                Principal ventana = new Principal();
                ventana.Show();
                this.Hide();
            }
            else 
            {
                MostrarError("Usuario y/o contraseña inválidas.", true);
                LimpiarCampos();
                this.txtUsuario.Focus();
                return;
            }
        }
        private void LimpiarCampos() { txtUsuario.Clear(); txtContrasenia.Clear(); }

        private bool validarCampos(string nombre, string contrasenia)
        {
            if (string.IsNullOrEmpty(nombre)) { MostrarError("Debe ingresar su usuario.", true); txtUsuario.Focus(); return true; }
            if (string.IsNullOrEmpty(contrasenia)) { MostrarError("Debe ingresar su contraseña.", true); txtContrasenia.Focus(); return true; }
            return false;
        }

        private void MostrarError(string mensaje, bool mostrar)
        {
            if (mostrar)  new frmNotificacion(mensaje, Color.FromArgb(220, 20, 60), 3);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
