namespace TurnadorClient.Vistas.Turnos
{
    partial class Posponer
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblIdTurno = new System.Windows.Forms.Label();
            this.lblIdUnidadNegocio = new System.Windows.Forms.Label();
            this.cmdPosponer = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.cmbUnidadNegocio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Posponer";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(15, 41);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblIdTurno
            // 
            this.lblIdTurno.AutoSize = true;
            this.lblIdTurno.Location = new System.Drawing.Point(15, 93);
            this.lblIdTurno.Name = "lblIdTurno";
            this.lblIdTurno.Size = new System.Drawing.Size(38, 13);
            this.lblIdTurno.TabIndex = 2;
            this.lblIdTurno.Text = "Turno:";
            // 
            // lblIdUnidadNegocio
            // 
            this.lblIdUnidadNegocio.AutoSize = true;
            this.lblIdUnidadNegocio.Location = new System.Drawing.Point(15, 65);
            this.lblIdUnidadNegocio.Name = "lblIdUnidadNegocio";
            this.lblIdUnidadNegocio.Size = new System.Drawing.Size(102, 13);
            this.lblIdUnidadNegocio.TabIndex = 3;
            this.lblIdUnidadNegocio.Text = "Unidad de Negocio:";
            // 
            // cmdPosponer
            // 
            this.cmdPosponer.Location = new System.Drawing.Point(197, 131);
            this.cmdPosponer.Name = "cmdPosponer";
            this.cmdPosponer.Size = new System.Drawing.Size(75, 23);
            this.cmdPosponer.TabIndex = 4;
            this.cmdPosponer.Text = "Posponer";
            this.cmdPosponer.UseVisualStyleBackColor = true;
            this.cmdPosponer.Click += new System.EventHandler(this.cmdPosponer_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(129, 38);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 5;
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(129, 90);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(100, 20);
            this.txtTurno.TabIndex = 6;
            // 
            // cmbUnidadNegocio
            // 
            this.cmbUnidadNegocio.FormattingEnabled = true;
            this.cmbUnidadNegocio.Location = new System.Drawing.Point(129, 65);
            this.cmbUnidadNegocio.Name = "cmbUnidadNegocio";
            this.cmbUnidadNegocio.Size = new System.Drawing.Size(100, 21);
            this.cmbUnidadNegocio.TabIndex = 7;
            // 
            // Posponer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.cmbUnidadNegocio);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cmdPosponer);
            this.Controls.Add(this.lblIdUnidadNegocio);
            this.Controls.Add(this.lblIdTurno);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Posponer";
            this.Text = "Posponer";
            this.Load += new System.EventHandler(this.Posponer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblIdTurno;
        private System.Windows.Forms.Label lblIdUnidadNegocio;
        private System.Windows.Forms.Button cmdPosponer;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.ComboBox cmbUnidadNegocio;
    }
}