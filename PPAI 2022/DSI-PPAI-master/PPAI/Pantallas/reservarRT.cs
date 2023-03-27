using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PPAI.Clases;


namespace PPAI
{
    public partial class reservarRT : Form
    {
        public reservarRT()
        {
            InitializeComponent();
        }

        #region Eventos
        private void reservarRT_Load(object sender, EventArgs e) { habilitarPantalla();}
        private void listaTipos_SelectedValueChanged(object sender, EventArgs e) { tomarSeleccionTipoRT(); } 
        private void tablaRecursos_CellClick(object sender, DataGridViewCellEventArgs e) { tomarSeleccionRT(); }
        private void listadoTurnos_CellClick(object sender, DataGridViewCellEventArgs e) { tomarSeleccionTurno(); }
        private void btnReservarRecurso_Click(object sender, EventArgs e) { tomarConfirmacion(); }
        private void btnCancelar_Click(object sender, EventArgs e) { limpiarDatos(); }
        #endregion


        #region Metodos

        private void habilitarPantalla() 
        {
            foreach (string tipo in Gestor.GetGestor().opcionReservaTurno()) { listaTipos.Items.Add(tipo); }

            cargarGrillaRecurso("TODOS");
        }
        public void tomarSeleccionTipoRT()
        {
            limpiarGrilla();
            limpiarDatos();
            cargarGrillaRecurso(listaTipos.SelectedItem.ToString());
        }
        private void cargarGrillaRecurso(string tipo)
        {
            foreach (List<string> recurso in Gestor.GetGestor().tomarSeleccionTipoRT(tipo))
            {
                tablaRecursos.Rows.Add(recurso[0], recurso[1], recurso[2],recurso[3], recurso[4]);
            }

            ordenarYAgruparRT();
        }
        private void tomarSeleccionRT()
        {
            limpiarDatos();

            var seleccionado = tablaRecursos[1, tablaRecursos.CurrentRow.Index].Value.ToString();
            Gestor.GetGestor().tomarSeleccionRT(seleccionado);

            cargarDetalle();

            if (Gestor.GetGestor().verificarCICientificoLog())
            {
                cargarGrillaTurno(DateTime.Now);
            }
            else 
            {
                new frmNotificacion("Debera realizar la reserva del turno con antelación.", Color.FromArgb(219, 175, 13), 1);
                var horas_antelacion = Gestor.GetGestor().recursoSeleccionado.mostrarCI(Gestor.GetGestor().centros).getTiempoAntelacion();
                cargarGrillaTurno(DateTime.Now.AddHours(horas_antelacion));
            }
           
        }

        public void cargarGrillaTurno(DateTime fecha)
        {
            List<List<String>> turnos = Gestor.GetGestor().obtenerTurnosReservables(fecha);
            foreach (List<String> turno in turnos)
            {
                if (tablaRecursos[4,tablaRecursos.CurrentRow.Index].Value.ToString() == "Disponible")
                    listadoTurnos.Rows.Add(turno[0], turno[1], turno[2], turno[3], turno[4]);
            }

            agruparYOrdenarTurnos();
        }
        private void tomarSeleccionTurno()
        {
            var mes = int.Parse(listadoTurnos["cMes", listadoTurnos.CurrentRow.Index].Value.ToString());
            var dia = int.Parse(listadoTurnos["cDia", listadoTurnos.CurrentRow.Index].Value.ToString());
            var hora = int.Parse(listadoTurnos["cHora", listadoTurnos.CurrentRow.Index].Value.ToString());
            var minutos = int.Parse(listadoTurnos["cMinutos", listadoTurnos.CurrentRow.Index].Value.ToString());
            var fecha = new DateTime(2022, mes, dia, hora, minutos, 00);
            btnReservarRecurso.Enabled = Gestor.GetGestor().tomarSeleccionTurno(fecha);
        }

        private void tomarConfirmacion()
        {
            if (Gestor.GetGestor().turnoSeleccionado != null)
            {
                Confirmar ventana = new Confirmar();
                
                ventana.Show();
            }
            else 
            {
                new frmNotificacion("Debe seleccionar un turno", Color.FromArgb(220, 20, 60), 3);
            }
            
            limpiarDatos();
        }

        private void limpiarDatos() {limpiarDetalle(); limpiarTurnos(); }
        private void limpiarGrilla() { tablaRecursos.Rows.Clear(); }
        private void limpiarTurnos() { listadoTurnos.Rows.Clear(); }
        private void limpiarDetalle() { txtCentro.Text = txtMarca.Text = txtModelo.Text = txtEstado.Text = txtNumero.Text = ""; /*imagenRecurso.Image = null;*/ }
        private void ordenarYAgruparRT() { tablaRecursos.Sort(tablaRecursos.Columns["cCentro"], ListSortDirection.Ascending); }
        private void agruparYOrdenarTurnos() { listadoTurnos.Sort(listadoTurnos.Columns["cDia"], ListSortDirection.Ascending); }
        private void cargarDetalle()
        {
            int poc = tablaRecursos.CurrentRow.Index;
            txtCentro.Text = tablaRecursos[0, poc].Value.ToString();
            txtNumero.Text = tablaRecursos[1, poc].Value.ToString();
            txtMarca.Text = tablaRecursos[2, poc].Value.ToString();
            txtModelo.Text = tablaRecursos[3, poc].Value.ToString();
            txtEstado.Text = tablaRecursos[4, poc].Value.ToString();
            //string path = Path.GetFullPath(@"..\..\");
            //string imagen = _gestor.rtSeleccionado.getImagen();
            //string realPath = Path.Combine(path, @"Resources/", imagen);
            //imagenRecurso.Image = Image.FromFile(realPath);
            //imagenRecurso.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        

        #endregion
        private void tablaRecursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.tablaRecursos.Columns[e.ColumnIndex].Name == "cEstado")
            {
                if (e.Value.ToString() == "Disponible") { e.CellStyle.BackColor = Color.FromArgb(0, 98, 176); e.CellStyle.ForeColor = Color.White; }
                if (e.Value.ToString() == "En Mantenimiento") { e.CellStyle.BackColor = Color.FromArgb(74, 204, 71); e.CellStyle.ForeColor = Color.White; }
                if (e.Value.ToString() == "Con Inicio de Mantenimiento Correctivo") { e.CellStyle.BackColor = Color.Gray; e.CellStyle.ForeColor = Color.White; }
            }
        }

        private void listadoTurnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (listadoTurnos.Columns[e.ColumnIndex].Name == "cEstado2")
            {
                if (e.Value.ToString() == "Disponible") { e.CellStyle.BackColor = Color.FromArgb(0, 98, 176); e.CellStyle.ForeColor = Color.White; }
                if (e.Value.ToString() == "Con reserva pendiente de confirmacion") { e.CellStyle.BackColor = Color.Gray; e.CellStyle.ForeColor = Color.White; }
                if (e.Value.ToString() == "Reservado") { e.CellStyle.BackColor = Color.Red; e.CellStyle.ForeColor = Color.White; }
            }
        }
    }
}
