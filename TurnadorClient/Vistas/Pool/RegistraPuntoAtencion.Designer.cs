namespace TurnadorClient.Vistas.Pool
{
    partial class Registra_punto_atencion
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
            this.lblNoEmpleado = new System.Windows.Forms.Label();
            this.lblPuntoAtencion = new System.Windows.Forms.Label();
            this.txtNoEmpleado = new System.Windows.Forms.TextBox();
            this.txtPuntoAtencion = new System.Windows.Forms.TextBox();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNoEmpleado
            // 
            this.lblNoEmpleado.AutoSize = true;
            this.lblNoEmpleado.Location = new System.Drawing.Point(23, 29);
            this.lblNoEmpleado.Name = "lblNoEmpleado";
            this.lblNoEmpleado.Size = new System.Drawing.Size(114, 13);
            this.lblNoEmpleado.TabIndex = 0;
            this.lblNoEmpleado.Text = "Numero de empleado: ";
            // 
            // lblPuntoAtencion
            // 
            this.lblPuntoAtencion.AutoSize = true;
            this.lblPuntoAtencion.Location = new System.Drawing.Point(23, 64);
            this.lblPuntoAtencion.Name = "lblPuntoAtencion";
            this.lblPuntoAtencion.Size = new System.Drawing.Size(97, 13);
            this.lblPuntoAtencion.TabIndex = 1;
            this.lblPuntoAtencion.Text = "Punto de atencion:";
            // 
            // txtNoEmpleado
            // 
            this.txtNoEmpleado.Location = new System.Drawing.Point(144, 26);
            this.txtNoEmpleado.Name = "txtNoEmpleado";
            this.txtNoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNoEmpleado.TabIndex = 2;
            // 
            // txtPuntoAtencion
            // 
            this.txtPuntoAtencion.Location = new System.Drawing.Point(144, 64);
            this.txtPuntoAtencion.Name = "txtPuntoAtencion";
            this.txtPuntoAtencion.Size = new System.Drawing.Size(225, 20);
            this.txtPuntoAtencion.TabIndex = 3;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(294, 96);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar.TabIndex = 4;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // Registra_punto_atencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 131);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.txtPuntoAtencion);
            this.Controls.Add(this.txtNoEmpleado);
            this.Controls.Add(this.lblPuntoAtencion);
            this.Controls.Add(this.lblNoEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Registra_punto_atencion";
            this.Text = "Registra punto atencion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoEmpleado;
        private System.Windows.Forms.Label lblPuntoAtencion;
        private System.Windows.Forms.TextBox txtNoEmpleado;
        private System.Windows.Forms.TextBox txtPuntoAtencion;
        private System.Windows.Forms.Button cmdAceptar;
    }
}