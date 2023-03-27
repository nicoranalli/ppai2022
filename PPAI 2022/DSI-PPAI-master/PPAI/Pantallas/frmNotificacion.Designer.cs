using System.Windows.Forms;

namespace PPAI
{
    partial class frmNotificacion
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
            this.components = new System.ComponentModel.Container();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.imgNotificacion = new System.Windows.Forms.PictureBox();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgNotificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(61, 12);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(3);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(227, 45);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgNotificacion
            // 
            this.imgNotificacion.InitialImage = null;
            this.imgNotificacion.Location = new System.Drawing.Point(11, 11);
            this.imgNotificacion.Margin = new System.Windows.Forms.Padding(2);
            this.imgNotificacion.Name = "imgNotificacion";
            this.imgNotificacion.Size = new System.Drawing.Size(45, 45);
            this.imgNotificacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNotificacion.TabIndex = 1;
            this.imgNotificacion.TabStop = false;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 3000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // frmNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(300, 70);
            this.Controls.Add(this.imgNotificacion);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotificacion";
            this.Text = "Notificacion";
            this.Load += new System.EventHandler(this.Notificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgNotificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblMensaje;
        private PictureBox imgNotificacion;
        private System.Windows.Forms.Timer timerClose;
    }
}