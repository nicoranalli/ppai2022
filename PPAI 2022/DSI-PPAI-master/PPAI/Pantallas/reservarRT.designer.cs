namespace PPAI
{
    partial class reservarRT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservarRT));
            this.lblBievenido = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.listaTipos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grpRT = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tablaRecursos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cCentro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipoRT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grpDetalles = new Guna.UI2.WinForms.Guna2GroupBox();
            this.imagenRecurso = new System.Windows.Forms.PictureBox();
            this.txtEstado = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtModelo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCentro = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEstado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblModelo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMarca = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNumero = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCentro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grpTurnos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.listadoTurnos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEstado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMinutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReservarRecurso = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.grpRT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRecursos)).BeginInit();
            this.grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenRecurso)).BeginInit();
            this.grpTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBievenido
            // 
            this.lblBievenido.AutoSize = false;
            this.lblBievenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBievenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBievenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.lblBievenido.Location = new System.Drawing.Point(159, 14);
            this.lblBievenido.Margin = new System.Windows.Forms.Padding(2);
            this.lblBievenido.Name = "lblBievenido";
            this.lblBievenido.Size = new System.Drawing.Size(478, 39);
            this.lblBievenido.TabIndex = 99;
            this.lblBievenido.TabStop = false;
            this.lblBievenido.Text = "Reservar Turno Recurso Tecnológico";
            this.lblBievenido.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaTipos
            // 
            this.listaTipos.AutoRoundedCorners = true;
            this.listaTipos.BackColor = System.Drawing.Color.Transparent;
            this.listaTipos.BorderRadius = 17;
            this.listaTipos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listaTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaTipos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(219)))));
            this.listaTipos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listaTipos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listaTipos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listaTipos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.listaTipos.ItemHeight = 30;
            this.listaTipos.Items.AddRange(new object[] {
            "TODOS"});
            this.listaTipos.Location = new System.Drawing.Point(216, 49);
            this.listaTipos.Margin = new System.Windows.Forms.Padding(2);
            this.listaTipos.Name = "listaTipos";
            this.listaTipos.Size = new System.Drawing.Size(515, 36);
            this.listaTipos.StartIndex = 0;
            this.listaTipos.TabIndex = 2;
            this.listaTipos.TextOffset = new System.Drawing.Point(5, 0);
            this.listaTipos.SelectedValueChanged += new System.EventHandler(this.listaTipos_SelectedValueChanged);
            // 
            // grpRT
            // 
            this.grpRT.Controls.Add(this.tablaRecursos);
            this.grpRT.Controls.Add(this.lblTipoRT);
            this.grpRT.Controls.Add(this.listaTipos);
            this.grpRT.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(219)))));
            this.grpRT.CustomBorderThickness = new System.Windows.Forms.Padding(0, 36, 0, 0);
            this.grpRT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.grpRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.grpRT.Location = new System.Drawing.Point(24, 67);
            this.grpRT.Margin = new System.Windows.Forms.Padding(2);
            this.grpRT.Name = "grpRT";
            this.grpRT.Size = new System.Drawing.Size(750, 214);
            this.grpRT.TabIndex = 1;
            this.grpRT.Text = "Recursos Tecnológicos";
            // 
            // tablaRecursos
            // 
            this.tablaRecursos.AllowUserToAddRows = false;
            this.tablaRecursos.AllowUserToDeleteRows = false;
            this.tablaRecursos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.tablaRecursos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.tablaRecursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRecursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaRecursos.ColumnHeadersHeight = 16;
            this.tablaRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCentro,
            this.cNumero,
            this.cMarca,
            this.cModelo,
            this.cEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaRecursos.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaRecursos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.tablaRecursos.Location = new System.Drawing.Point(25, 100);
            this.tablaRecursos.Margin = new System.Windows.Forms.Padding(2);
            this.tablaRecursos.Name = "tablaRecursos";
            this.tablaRecursos.ReadOnly = true;
            this.tablaRecursos.RowHeadersVisible = false;
            this.tablaRecursos.RowHeadersWidth = 51;
            this.tablaRecursos.Size = new System.Drawing.Size(706, 91);
            this.tablaRecursos.TabIndex = 3;
            this.tablaRecursos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.tablaRecursos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.tablaRecursos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaRecursos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaRecursos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaRecursos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaRecursos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.tablaRecursos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.tablaRecursos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.tablaRecursos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaRecursos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaRecursos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaRecursos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaRecursos.ThemeStyle.HeaderStyle.Height = 16;
            this.tablaRecursos.ThemeStyle.ReadOnly = true;
            this.tablaRecursos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.tablaRecursos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaRecursos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaRecursos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.tablaRecursos.ThemeStyle.RowsStyle.Height = 22;
            this.tablaRecursos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.tablaRecursos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaRecursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRecursos_CellClick);
            this.tablaRecursos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tablaRecursos_CellFormatting);
            // 
            // cCentro
            // 
            this.cCentro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cCentro.HeaderText = "Centro";
            this.cCentro.MinimumWidth = 20;
            this.cCentro.Name = "cCentro";
            this.cCentro.ReadOnly = true;
            // 
            // cNumero
            // 
            this.cNumero.HeaderText = "Nº";
            this.cNumero.MinimumWidth = 6;
            this.cNumero.Name = "cNumero";
            this.cNumero.ReadOnly = true;
            this.cNumero.Width = 45;
            // 
            // cMarca
            // 
            this.cMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cMarca.FillWeight = 110F;
            this.cMarca.HeaderText = "Marca";
            this.cMarca.MinimumWidth = 60;
            this.cMarca.Name = "cMarca";
            this.cMarca.ReadOnly = true;
            // 
            // cModelo
            // 
            this.cModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cModelo.FillWeight = 110F;
            this.cModelo.HeaderText = "Modelo";
            this.cModelo.MinimumWidth = 6;
            this.cModelo.Name = "cModelo";
            this.cModelo.ReadOnly = true;
            // 
            // cEstado
            // 
            this.cEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cEstado.FillWeight = 80F;
            this.cEstado.HeaderText = "Estado";
            this.cEstado.MinimumWidth = 6;
            this.cEstado.Name = "cEstado";
            this.cEstado.ReadOnly = true;
            // 
            // lblTipoRT
            // 
            this.lblTipoRT.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.lblTipoRT.Location = new System.Drawing.Point(25, 56);
            this.lblTipoRT.Margin = new System.Windows.Forms.Padding(2);
            this.lblTipoRT.Name = "lblTipoRT";
            this.lblTipoRT.Size = new System.Drawing.Size(171, 18);
            this.lblTipoRT.TabIndex = 99;
            this.lblTipoRT.TabStop = false;
            this.lblTipoRT.Text = "Tipo de recurso tecnológico";
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.imagenRecurso);
            this.grpDetalles.Controls.Add(this.txtEstado);
            this.grpDetalles.Controls.Add(this.txtModelo);
            this.grpDetalles.Controls.Add(this.txtMarca);
            this.grpDetalles.Controls.Add(this.txtNumero);
            this.grpDetalles.Controls.Add(this.txtCentro);
            this.grpDetalles.Controls.Add(this.lblEstado);
            this.grpDetalles.Controls.Add(this.lblModelo);
            this.grpDetalles.Controls.Add(this.lblMarca);
            this.grpDetalles.Controls.Add(this.lblNumero);
            this.grpDetalles.Controls.Add(this.lblCentro);
            this.grpDetalles.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(219)))));
            this.grpDetalles.CustomBorderThickness = new System.Windows.Forms.Padding(0, 36, 0, 0);
            this.grpDetalles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.grpDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.grpDetalles.Location = new System.Drawing.Point(24, 305);
            this.grpDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(372, 238);
            this.grpDetalles.TabIndex = 98;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles";
            // 
            // imagenRecurso
            // 
            this.imagenRecurso.Location = new System.Drawing.Point(138, 56);
            this.imagenRecurso.Margin = new System.Windows.Forms.Padding(2);
            this.imagenRecurso.Name = "imagenRecurso";
            this.imagenRecurso.Size = new System.Drawing.Size(91, 89);
            this.imagenRecurso.TabIndex = 100;
            this.imagenRecurso.TabStop = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstado.DefaultText = "";
            this.txtEstado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEstado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEstado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEstado.Enabled = false;
            this.txtEstado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.txtEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEstado.Location = new System.Drawing.Point(231, 207);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.PlaceholderText = "";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.SelectedText = "";
            this.txtEstado.Size = new System.Drawing.Size(116, 11);
            this.txtEstado.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEstado.TabIndex = 99;
            this.txtEstado.TabStop = false;
            // 
            // txtModelo
            // 
            this.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelo.DefaultText = "";
            this.txtModelo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtModelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModelo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModelo.Enabled = false;
            this.txtModelo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.txtModelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModelo.Location = new System.Drawing.Point(85, 204);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.PlaceholderText = "";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.SelectedText = "";
            this.txtModelo.Size = new System.Drawing.Size(79, 11);
            this.txtModelo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtModelo.TabIndex = 99;
            this.txtModelo.TabStop = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.DefaultText = "";
            this.txtMarca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarca.Enabled = false;
            this.txtMarca.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.txtMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarca.Location = new System.Drawing.Point(189, 187);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.PlaceholderText = "";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.SelectedText = "";
            this.txtMarca.Size = new System.Drawing.Size(158, 11);
            this.txtMarca.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMarca.TabIndex = 99;
            this.txtMarca.TabStop = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.DefaultText = "";
            this.txtNumero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.Enabled = false;
            this.txtNumero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.txtNumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.Location = new System.Drawing.Point(48, 189);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.PlaceholderText = "";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.SelectedText = "";
            this.txtNumero.Size = new System.Drawing.Size(73, 11);
            this.txtNumero.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNumero.TabIndex = 99;
            this.txtNumero.TabStop = false;
            // 
            // txtCentro
            // 
            this.txtCentro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCentro.DefaultText = "";
            this.txtCentro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCentro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCentro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCentro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCentro.Enabled = false;
            this.txtCentro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.txtCentro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCentro.Location = new System.Drawing.Point(72, 170);
            this.txtCentro.Margin = new System.Windows.Forms.Padding(2);
            this.txtCentro.Name = "txtCentro";
            this.txtCentro.PasswordChar = '\0';
            this.txtCentro.PlaceholderText = "";
            this.txtCentro.ReadOnly = true;
            this.txtCentro.SelectedText = "";
            this.txtCentro.Size = new System.Drawing.Size(275, 11);
            this.txtCentro.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCentro.TabIndex = 99;
            this.txtCentro.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.lblEstado.Location = new System.Drawing.Point(178, 204);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 18);
            this.lblEstado.TabIndex = 99;
            this.lblEstado.TabStop = false;
            this.lblEstado.Text = "Estado";
            // 
            // lblModelo
            // 
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.lblModelo.Location = new System.Drawing.Point(25, 201);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 18);
            this.lblModelo.TabIndex = 99;
            this.lblModelo.TabStop = false;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.lblMarca.Location = new System.Drawing.Point(138, 184);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(41, 18);
            this.lblMarca.TabIndex = 16;
            this.lblMarca.TabStop = false;
            this.lblMarca.Text = "Marca";
            // 
            // lblNumero
            // 
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.lblNumero.Location = new System.Drawing.Point(25, 184);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(18, 18);
            this.lblNumero.TabIndex = 99;
            this.lblNumero.TabStop = false;
            this.lblNumero.Text = "Nº";
            // 
            // lblCentro
            // 
            this.lblCentro.BackColor = System.Drawing.Color.Transparent;
            this.lblCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.lblCentro.Location = new System.Drawing.Point(25, 167);
            this.lblCentro.Margin = new System.Windows.Forms.Padding(2);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(42, 18);
            this.lblCentro.TabIndex = 99;
            this.lblCentro.TabStop = false;
            this.lblCentro.Text = "Centro";
            // 
            // grpTurnos
            // 
            this.grpTurnos.Controls.Add(this.listadoTurnos);
            this.grpTurnos.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(219)))));
            this.grpTurnos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 36, 0, 0);
            this.grpTurnos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.grpTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTurnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.grpTurnos.Location = new System.Drawing.Point(421, 305);
            this.grpTurnos.Margin = new System.Windows.Forms.Padding(2);
            this.grpTurnos.Name = "grpTurnos";
            this.grpTurnos.Size = new System.Drawing.Size(353, 238);
            this.grpTurnos.TabIndex = 4;
            this.grpTurnos.Text = "Turnos";
            // 
            // listadoTurnos
            // 
            this.listadoTurnos.AllowUserToAddRows = false;
            this.listadoTurnos.AllowUserToDeleteRows = false;
            this.listadoTurnos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.listadoTurnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.listadoTurnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.listadoTurnos.ColumnHeadersHeight = 16;
            this.listadoTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMes,
            this.cDia,
            this.cEstado2,
            this.Chora,
            this.cMinutos});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoTurnos.DefaultCellStyle = dataGridViewCellStyle6;
            this.listadoTurnos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.listadoTurnos.Location = new System.Drawing.Point(21, 56);
            this.listadoTurnos.Margin = new System.Windows.Forms.Padding(2);
            this.listadoTurnos.Name = "listadoTurnos";
            this.listadoTurnos.ReadOnly = true;
            this.listadoTurnos.RowHeadersVisible = false;
            this.listadoTurnos.RowHeadersWidth = 51;
            this.listadoTurnos.Size = new System.Drawing.Size(313, 159);
            this.listadoTurnos.TabIndex = 5;
            this.listadoTurnos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.listadoTurnos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.listadoTurnos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listadoTurnos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listadoTurnos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listadoTurnos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listadoTurnos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.listadoTurnos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.listadoTurnos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.listadoTurnos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listadoTurnos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoTurnos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listadoTurnos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listadoTurnos.ThemeStyle.HeaderStyle.Height = 16;
            this.listadoTurnos.ThemeStyle.ReadOnly = true;
            this.listadoTurnos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.listadoTurnos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listadoTurnos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoTurnos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.listadoTurnos.ThemeStyle.RowsStyle.Height = 22;
            this.listadoTurnos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.listadoTurnos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.listadoTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoTurnos_CellClick);
            this.listadoTurnos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.listadoTurnos_CellFormatting);
            // 
            // cMes
            // 
            this.cMes.HeaderText = "Mes";
            this.cMes.MinimumWidth = 6;
            this.cMes.Name = "cMes";
            this.cMes.ReadOnly = true;
            // 
            // cDia
            // 
            this.cDia.HeaderText = "Día";
            this.cDia.MinimumWidth = 6;
            this.cDia.Name = "cDia";
            this.cDia.ReadOnly = true;
            // 
            // cEstado2
            // 
            this.cEstado2.HeaderText = "Estado";
            this.cEstado2.MinimumWidth = 6;
            this.cEstado2.Name = "cEstado2";
            this.cEstado2.ReadOnly = true;
            // 
            // Chora
            // 
            this.Chora.HeaderText = "Hora";
            this.Chora.MinimumWidth = 6;
            this.Chora.Name = "Chora";
            this.Chora.ReadOnly = true;
            // 
            // cMinutos
            // 
            this.cMinutos.HeaderText = "Minutos";
            this.cMinutos.MinimumWidth = 6;
            this.cMinutos.Name = "cMinutos";
            this.cMinutos.ReadOnly = true;
            // 
            // btnReservarRecurso
            // 
            this.btnReservarRecurso.Animated = true;
            this.btnReservarRecurso.AutoRoundedCorners = true;
            this.btnReservarRecurso.BackColor = System.Drawing.Color.Transparent;
            this.btnReservarRecurso.BorderRadius = 13;
            this.btnReservarRecurso.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReservarRecurso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReservarRecurso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReservarRecurso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReservarRecurso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnReservarRecurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnReservarRecurso.ForeColor = System.Drawing.Color.White;
            this.btnReservarRecurso.IndicateFocus = true;
            this.btnReservarRecurso.Location = new System.Drawing.Point(578, 561);
            this.btnReservarRecurso.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservarRecurso.Name = "btnReservarRecurso";
            this.btnReservarRecurso.Size = new System.Drawing.Size(196, 29);
            this.btnReservarRecurso.TabIndex = 9;
            this.btnReservarRecurso.Text = "Reservar Recurso";
            this.btnReservarRecurso.Click += new System.EventHandler(this.btnReservarRecurso_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Animated = true;
            this.btnCancelar.AutoRoundedCorners = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderRadius = 13;
            this.btnCancelar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnCancelar.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnCancelar.FocusedColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IndicateFocus = true;
            this.btnCancelar.Location = new System.Drawing.Point(442, 561);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 29);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseTransparentBackground = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // reservarRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.ControlBox = false;
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReservarRecurso);
            this.Controls.Add(this.grpTurnos);
            this.Controls.Add(this.grpRT);
            this.Controls.Add(this.lblBievenido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "reservarRT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservarRTLight";
            this.Load += new System.EventHandler(this.reservarRT_Load);
            this.grpRT.ResumeLayout(false);
            this.grpRT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRecursos)).EndInit();
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenRecurso)).EndInit();
            this.grpTurnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBievenido;
        private Guna.UI2.WinForms.Guna2ComboBox listaTipos;
        private Guna.UI2.WinForms.Guna2GroupBox grpRT;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTipoRT;
        private Guna.UI2.WinForms.Guna2GroupBox grpDetalles;
        private Guna.UI2.WinForms.Guna2DataGridView tablaRecursos;
        private Guna.UI2.WinForms.Guna2TextBox txtCentro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstado;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModelo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMarca;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumero;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCentro;
        private Guna.UI2.WinForms.Guna2TextBox txtEstado;
        private Guna.UI2.WinForms.Guna2TextBox txtModelo;
        private Guna.UI2.WinForms.Guna2TextBox txtMarca;
        private Guna.UI2.WinForms.Guna2TextBox txtNumero;
        private Guna.UI2.WinForms.Guna2GroupBox grpTurnos;
        private Guna.UI2.WinForms.Guna2Button btnReservarRecurso;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2DataGridView listadoTurnos;
        private System.Windows.Forms.PictureBox imagenRecurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCentro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEstado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chora;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMinutos;
    }
}