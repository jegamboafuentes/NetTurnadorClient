namespace TurnadorClient.Vistas.Turnos
{
    partial class Virtual
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
            this.lblNoEmpleado = new System.Windows.Forms.Label();
            this.lblUnidadNegocio = new System.Windows.Forms.Label();
            this.txtNoEmpleado = new System.Windows.Forms.TextBox();
            this.txtUnidadNegocio = new System.Windows.Forms.TextBox();
            this.cmdSmart = new System.Windows.Forms.Button();
            this.cmdGenerarVirtual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(102, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Atender turno virtual";
            // 
            // lblNoEmpleado
            // 
            this.lblNoEmpleado.AutoSize = true;
            this.lblNoEmpleado.Location = new System.Drawing.Point(12, 44);
            this.lblNoEmpleado.Name = "lblNoEmpleado";
            this.lblNoEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblNoEmpleado.TabIndex = 1;
            this.lblNoEmpleado.Text = "Empleado";
            // 
            // lblUnidadNegocio
            // 
            this.lblUnidadNegocio.AutoSize = true;
            this.lblUnidadNegocio.Location = new System.Drawing.Point(12, 73);
            this.lblUnidadNegocio.Name = "lblUnidadNegocio";
            this.lblUnidadNegocio.Size = new System.Drawing.Size(97, 13);
            this.lblUnidadNegocio.TabIndex = 2;
            this.lblUnidadNegocio.Text = "Unidad de negocio";
            // 
            // txtNoEmpleado
            // 
            this.txtNoEmpleado.Location = new System.Drawing.Point(130, 41);
            this.txtNoEmpleado.Name = "txtNoEmpleado";
            this.txtNoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNoEmpleado.TabIndex = 3;
            this.txtNoEmpleado.TextChanged += new System.EventHandler(this.txtNoEmpelado_TextChanged);
            // 
            // txtUnidadNegocio
            // 
            this.txtUnidadNegocio.Location = new System.Drawing.Point(130, 70);
            this.txtUnidadNegocio.Name = "txtUnidadNegocio";
            this.txtUnidadNegocio.Size = new System.Drawing.Size(100, 20);
            this.txtUnidadNegocio.TabIndex = 4;
            // 
            // cmdSmart
            // 
            this.cmdSmart.Location = new System.Drawing.Point(236, 41);
            this.cmdSmart.Name = "cmdSmart";
            this.cmdSmart.Size = new System.Drawing.Size(19, 20);
            this.cmdSmart.TabIndex = 10;
            this.cmdSmart.Text = "•";
            this.cmdSmart.UseVisualStyleBackColor = true;
            this.cmdSmart.Click += new System.EventHandler(this.cmdSmart_Click_1);
            // 
            // cmdGenerarVirtual
            // 
            this.cmdGenerarVirtual.Location = new System.Drawing.Point(193, 110);
            this.cmdGenerarVirtual.Name = "cmdGenerarVirtual";
            this.cmdGenerarVirtual.Size = new System.Drawing.Size(62, 24);
            this.cmdGenerarVirtual.TabIndex = 11;
            this.cmdGenerarVirtual.Text = "Atender";
            this.cmdGenerarVirtual.UseVisualStyleBackColor = true;
            this.cmdGenerarVirtual.Click += new System.EventHandler(this.cmdGenerarVirtual_Click);
            // 
            // Virtual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.cmdGenerarVirtual);
            this.Controls.Add(this.cmdSmart);
            this.Controls.Add(this.txtUnidadNegocio);
            this.Controls.Add(this.txtNoEmpleado);
            this.Controls.Add(this.lblUnidadNegocio);
            this.Controls.Add(this.lblNoEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Virtual";
            this.Text = "Virtual";
            this.Load += new System.EventHandler(this.Virtual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNoEmpleado;
        private System.Windows.Forms.Label lblUnidadNegocio;
        private System.Windows.Forms.TextBox txtNoEmpleado;
        private System.Windows.Forms.TextBox txtUnidadNegocio;
        private System.Windows.Forms.Button cmdSmart;
        private System.Windows.Forms.Button cmdGenerarVirtual;
    }
}