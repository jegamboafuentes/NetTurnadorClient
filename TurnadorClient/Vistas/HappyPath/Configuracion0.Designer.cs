namespace TurnadorClient.Vistas.HappyPath
{
    partial class Configuracion0
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
            this.radioButtonSencillo = new System.Windows.Forms.RadioButton();
            this.radioButtonAvanzado = new System.Windows.Forms.RadioButton();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonSencillo
            // 
            this.radioButtonSencillo.AutoSize = true;
            this.radioButtonSencillo.Location = new System.Drawing.Point(51, 27);
            this.radioButtonSencillo.Name = "radioButtonSencillo";
            this.radioButtonSencillo.Size = new System.Drawing.Size(62, 17);
            this.radioButtonSencillo.TabIndex = 0;
            this.radioButtonSencillo.TabStop = true;
            this.radioButtonSencillo.Text = "Sencillo";
            this.radioButtonSencillo.UseVisualStyleBackColor = true;
            this.radioButtonSencillo.CheckedChanged += new System.EventHandler(this.radioButtonSencillo_CheckedChanged);
            // 
            // radioButtonAvanzado
            // 
            this.radioButtonAvanzado.AutoSize = true;
            this.radioButtonAvanzado.Location = new System.Drawing.Point(158, 27);
            this.radioButtonAvanzado.Name = "radioButtonAvanzado";
            this.radioButtonAvanzado.Size = new System.Drawing.Size(73, 17);
            this.radioButtonAvanzado.TabIndex = 1;
            this.radioButtonAvanzado.TabStop = true;
            this.radioButtonAvanzado.Text = "Avanzado";
            this.radioButtonAvanzado.UseVisualStyleBackColor = true;
            this.radioButtonAvanzado.CheckedChanged += new System.EventHandler(this.radioButtonAvanzado_CheckedChanged);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(96, 62);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar.TabIndex = 2;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // Configuracion0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 95);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.radioButtonAvanzado);
            this.Controls.Add(this.radioButtonSencillo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Configuracion0";
            this.Text = "Configuracion Happy Path";
            this.Load += new System.EventHandler(this.Configuracion0_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSencillo;
        private System.Windows.Forms.RadioButton radioButtonAvanzado;
        private System.Windows.Forms.Button cmdAceptar;
    }
}