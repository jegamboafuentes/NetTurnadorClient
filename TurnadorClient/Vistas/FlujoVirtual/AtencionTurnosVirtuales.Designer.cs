namespace TurnadorClient.Vistas.Virtual
{
    partial class AtencionTurnosVirtuales
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
            this.lblEmpNo = new System.Windows.Forms.Label();
            this.txtnoEmpleado = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.cmdVirtual = new System.Windows.Forms.Button();
            this.lblbCantidadTurnos = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(2, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Atencion turnos virtuales";
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.Location = new System.Drawing.Point(28, 34);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(57, 13);
            this.lblEmpNo.TabIndex = 1;
            this.lblEmpNo.Text = "Empleado:";
            // 
            // txtnoEmpleado
            // 
            this.txtnoEmpleado.Location = new System.Drawing.Point(91, 31);
            this.txtnoEmpleado.Name = "txtnoEmpleado";
            this.txtnoEmpleado.Size = new System.Drawing.Size(124, 20);
            this.txtnoEmpleado.TabIndex = 2;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(33, 101);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(141, 13);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "Tiempo mínimo de atención:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(33, 127);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(142, 13);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Tiempo máximo de atención:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(178, 98);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(39, 20);
            this.txtMin.TabIndex = 5;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(178, 127);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(39, 20);
            this.txtMax.TabIndex = 6;
            // 
            // cmdVirtual
            // 
            this.cmdVirtual.Location = new System.Drawing.Point(31, 159);
            this.cmdVirtual.Name = "cmdVirtual";
            this.cmdVirtual.Size = new System.Drawing.Size(184, 23);
            this.cmdVirtual.TabIndex = 7;
            this.cmdVirtual.Text = "Atender turno virtual";
            this.cmdVirtual.UseVisualStyleBackColor = true;
            this.cmdVirtual.Click += new System.EventHandler(this.cmdVirtual_Click);
            // 
            // lblbCantidadTurnos
            // 
            this.lblbCantidadTurnos.AutoSize = true;
            this.lblbCantidadTurnos.Location = new System.Drawing.Point(33, 72);
            this.lblbCantidadTurnos.Name = "lblbCantidadTurnos";
            this.lblbCantidadTurnos.Size = new System.Drawing.Size(99, 13);
            this.lblbCantidadTurnos.TabIndex = 8;
            this.lblbCantidadTurnos.Text = "Cantidad de turnos:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(178, 69);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(39, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // AtencionTurnosVirtuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 204);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblbCantidadTurnos);
            this.Controls.Add(this.cmdVirtual);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtnoEmpleado);
            this.Controls.Add(this.lblEmpNo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AtencionTurnosVirtuales";
            this.Text = "AtencionTurnosVirtuales";
            this.Load += new System.EventHandler(this.AtencionTurnosVirtuales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmpNo;
        private System.Windows.Forms.TextBox txtnoEmpleado;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button cmdVirtual;
        private System.Windows.Forms.Label lblbCantidadTurnos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}