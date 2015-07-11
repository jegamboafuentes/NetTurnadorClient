namespace TurnadorClient.Vistas
{
    partial class Configuracion
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
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.radioButtonProduccion = new System.Windows.Forms.RadioButton();
            this.radioButtonDesarrollo = new System.Windows.Forms.RadioButton();
            this.checkBoxDisplay = new System.Windows.Forms.CheckBox();
            this.checkBoxNt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(32, 41);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(49, 13);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(157, 41);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(273, 20);
            this.txtServidor.TabIndex = 1;
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplo.Location = new System.Drawing.Point(155, 73);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(201, 9);
            this.lblEjemplo.TabIndex = 3;
            this.lblEjemplo.Text = "Escribe el numero de el servidor con ceros, ejemplo: 0055";
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(355, 143);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar.TabIndex = 4;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // radioButtonProduccion
            // 
            this.radioButtonProduccion.AutoSize = true;
            this.radioButtonProduccion.Location = new System.Drawing.Point(35, 12);
            this.radioButtonProduccion.Name = "radioButtonProduccion";
            this.radioButtonProduccion.Size = new System.Drawing.Size(88, 17);
            this.radioButtonProduccion.TabIndex = 5;
            this.radioButtonProduccion.TabStop = true;
            this.radioButtonProduccion.Text = "Servidor [NT]";
            this.radioButtonProduccion.UseVisualStyleBackColor = true;
            this.radioButtonProduccion.CheckedChanged += new System.EventHandler(this.radioButtonProduccion_CheckedChanged);
            // 
            // radioButtonDesarrollo
            // 
            this.radioButtonDesarrollo.AutoSize = true;
            this.radioButtonDesarrollo.Location = new System.Drawing.Point(145, 12);
            this.radioButtonDesarrollo.Name = "radioButtonDesarrollo";
            this.radioButtonDesarrollo.Size = new System.Drawing.Size(67, 17);
            this.radioButtonDesarrollo.TabIndex = 6;
            this.radioButtonDesarrollo.TabStop = true;
            this.radioButtonDesarrollo.Text = "localhost";
            this.radioButtonDesarrollo.UseVisualStyleBackColor = true;
            this.radioButtonDesarrollo.CheckedChanged += new System.EventHandler(this.radioButtonDesarrollo_CheckedChanged);
            // 
            // checkBoxDisplay
            // 
            this.checkBoxDisplay.AutoSize = true;
            this.checkBoxDisplay.Location = new System.Drawing.Point(35, 111);
            this.checkBoxDisplay.Name = "checkBoxDisplay";
            this.checkBoxDisplay.Size = new System.Drawing.Size(60, 17);
            this.checkBoxDisplay.TabIndex = 8;
            this.checkBoxDisplay.Text = "Display";
            this.checkBoxDisplay.UseVisualStyleBackColor = true;
            // 
            // checkBoxNt
            // 
            this.checkBoxNt.AutoSize = true;
            this.checkBoxNt.Location = new System.Drawing.Point(35, 58);
            this.checkBoxNt.Name = "checkBoxNt";
            this.checkBoxNt.Size = new System.Drawing.Size(67, 17);
            this.checkBoxNt.TabIndex = 9;
            this.checkBoxNt.Text = "DNS NT";
            this.checkBoxNt.UseVisualStyleBackColor = true;
            this.checkBoxNt.CheckedChanged += new System.EventHandler(this.checkBoxNt_CheckedChanged);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 169);
            this.Controls.Add(this.checkBoxNt);
            this.Controls.Add(this.checkBoxDisplay);
            this.Controls.Add(this.radioButtonDesarrollo);
            this.Controls.Add(this.radioButtonProduccion);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.RadioButton radioButtonProduccion;
        private System.Windows.Forms.RadioButton radioButtonDesarrollo;
        private System.Windows.Forms.CheckBox checkBoxDisplay;
        private System.Windows.Forms.CheckBox checkBoxNt;
    }
}