namespace TurnadorClient.Vistas.Turnos
{
    partial class AtenderTurno
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
            this.lblNoEmpleado = new System.Windows.Forms.Label();
            this.txtNoEmpleado = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtIdTurno = new System.Windows.Forms.TextBox();
            this.txtIdUnidadNegocio = new System.Windows.Forms.TextBox();
            this.cmdSmart = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(19, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Atender turno";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(19, 103);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblIdTurno
            // 
            this.lblIdTurno.AutoSize = true;
            this.lblIdTurno.Location = new System.Drawing.Point(19, 141);
            this.lblIdTurno.Name = "lblIdTurno";
            this.lblIdTurno.Size = new System.Drawing.Size(46, 13);
            this.lblIdTurno.TabIndex = 2;
            this.lblIdTurno.Text = "Id turno:";
            // 
            // lblIdUnidadNegocio
            // 
            this.lblIdUnidadNegocio.AutoSize = true;
            this.lblIdUnidadNegocio.Location = new System.Drawing.Point(19, 174);
            this.lblIdUnidadNegocio.Name = "lblIdUnidadNegocio";
            this.lblIdUnidadNegocio.Size = new System.Drawing.Size(95, 13);
            this.lblIdUnidadNegocio.TabIndex = 3;
            this.lblIdUnidadNegocio.Text = "Id unidad negocio:";
            // 
            // lblNoEmpleado
            // 
            this.lblNoEmpleado.AutoSize = true;
            this.lblNoEmpleado.Location = new System.Drawing.Point(19, 66);
            this.lblNoEmpleado.Name = "lblNoEmpleado";
            this.lblNoEmpleado.Size = new System.Drawing.Size(76, 13);
            this.lblNoEmpleado.TabIndex = 4;
            this.lblNoEmpleado.Text = "No. empleado:";
            // 
            // txtNoEmpleado
            // 
            this.txtNoEmpleado.Location = new System.Drawing.Point(147, 59);
            this.txtNoEmpleado.Name = "txtNoEmpleado";
            this.txtNoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNoEmpleado.TabIndex = 5;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(147, 95);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 6;
            // 
            // txtIdTurno
            // 
            this.txtIdTurno.Location = new System.Drawing.Point(147, 133);
            this.txtIdTurno.Name = "txtIdTurno";
            this.txtIdTurno.Size = new System.Drawing.Size(100, 20);
            this.txtIdTurno.TabIndex = 7;
            // 
            // txtIdUnidadNegocio
            // 
            this.txtIdUnidadNegocio.Location = new System.Drawing.Point(147, 171);
            this.txtIdUnidadNegocio.Name = "txtIdUnidadNegocio";
            this.txtIdUnidadNegocio.Size = new System.Drawing.Size(100, 20);
            this.txtIdUnidadNegocio.TabIndex = 8;
            // 
            // cmdSmart
            // 
            this.cmdSmart.Location = new System.Drawing.Point(255, 95);
            this.cmdSmart.Name = "cmdSmart";
            this.cmdSmart.Size = new System.Drawing.Size(19, 20);
            this.cmdSmart.TabIndex = 9;
            this.cmdSmart.Text = "•";
            this.cmdSmart.UseVisualStyleBackColor = true;
            this.cmdSmart.Click += new System.EventHandler(this.cmdSmart_Click);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(172, 214);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar.TabIndex = 10;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // AtenderTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 246);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.cmdSmart);
            this.Controls.Add(this.txtIdUnidadNegocio);
            this.Controls.Add(this.txtIdTurno);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNoEmpleado);
            this.Controls.Add(this.lblNoEmpleado);
            this.Controls.Add(this.lblIdUnidadNegocio);
            this.Controls.Add(this.lblIdTurno);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AtenderTurno";
            this.Text = "AtenderTurno";
            this.Load += new System.EventHandler(this.AtenderTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblIdTurno;
        private System.Windows.Forms.Label lblIdUnidadNegocio;
        private System.Windows.Forms.Label lblNoEmpleado;
        private System.Windows.Forms.TextBox txtNoEmpleado;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtIdTurno;
        private System.Windows.Forms.TextBox txtIdUnidadNegocio;
        private System.Windows.Forms.Button cmdSmart;
        private System.Windows.Forms.Button cmdAceptar;
    }
}