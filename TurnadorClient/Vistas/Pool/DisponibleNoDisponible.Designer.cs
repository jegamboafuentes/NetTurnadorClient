namespace TurnadorClient.Vistas.Pool
{
    partial class DisponibleNoDisponible
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
            this.radioButtonNoDisponible = new System.Windows.Forms.RadioButton();
            this.radioButtonDisponible = new System.Windows.Forms.RadioButton();
            this.lblNoEmpleado = new System.Windows.Forms.Label();
            this.txtNoEmpleado = new System.Windows.Forms.TextBox();
            this.cmdAccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonNoDisponible
            // 
            this.radioButtonNoDisponible.AutoSize = true;
            this.radioButtonNoDisponible.Location = new System.Drawing.Point(12, 24);
            this.radioButtonNoDisponible.Name = "radioButtonNoDisponible";
            this.radioButtonNoDisponible.Size = new System.Drawing.Size(89, 17);
            this.radioButtonNoDisponible.TabIndex = 0;
            this.radioButtonNoDisponible.TabStop = true;
            this.radioButtonNoDisponible.Text = "No disponible";
            this.radioButtonNoDisponible.UseVisualStyleBackColor = true;
            this.radioButtonNoDisponible.CheckedChanged += new System.EventHandler(this.radioButtonNoDisponible_CheckedChanged);
            // 
            // radioButtonDisponible
            // 
            this.radioButtonDisponible.AutoSize = true;
            this.radioButtonDisponible.Location = new System.Drawing.Point(12, 47);
            this.radioButtonDisponible.Name = "radioButtonDisponible";
            this.radioButtonDisponible.Size = new System.Drawing.Size(74, 17);
            this.radioButtonDisponible.TabIndex = 1;
            this.radioButtonDisponible.TabStop = true;
            this.radioButtonDisponible.Text = "Disponible";
            this.radioButtonDisponible.UseVisualStyleBackColor = true;
            this.radioButtonDisponible.CheckedChanged += new System.EventHandler(this.radioButtonDisponible_CheckedChanged);
            // 
            // lblNoEmpleado
            // 
            this.lblNoEmpleado.AutoSize = true;
            this.lblNoEmpleado.Location = new System.Drawing.Point(145, 26);
            this.lblNoEmpleado.Name = "lblNoEmpleado";
            this.lblNoEmpleado.Size = new System.Drawing.Size(108, 13);
            this.lblNoEmpleado.TabIndex = 2;
            this.lblNoEmpleado.Text = "Numero de empleado";
            // 
            // txtNoEmpleado
            // 
            this.txtNoEmpleado.Location = new System.Drawing.Point(148, 51);
            this.txtNoEmpleado.Name = "txtNoEmpleado";
            this.txtNoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNoEmpleado.TabIndex = 3;
            // 
            // cmdAccion
            // 
            this.cmdAccion.Location = new System.Drawing.Point(148, 106);
            this.cmdAccion.Name = "cmdAccion";
            this.cmdAccion.Size = new System.Drawing.Size(100, 28);
            this.cmdAccion.TabIndex = 4;
            this.cmdAccion.Text = "Accion";
            this.cmdAccion.UseVisualStyleBackColor = true;
            this.cmdAccion.Click += new System.EventHandler(this.cmdAccion_Click);
            // 
            // DisponibleNoDisponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 144);
            this.Controls.Add(this.cmdAccion);
            this.Controls.Add(this.txtNoEmpleado);
            this.Controls.Add(this.lblNoEmpleado);
            this.Controls.Add(this.radioButtonDisponible);
            this.Controls.Add(this.radioButtonNoDisponible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DisponibleNoDisponible";
            this.Text = "DisponibleNoDisponible";
            this.Load += new System.EventHandler(this.DisponibleNoDisponible_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonNoDisponible;
        private System.Windows.Forms.RadioButton radioButtonDisponible;
        private System.Windows.Forms.Label lblNoEmpleado;
        private System.Windows.Forms.TextBox txtNoEmpleado;
        private System.Windows.Forms.Button cmdAccion;
    }
}