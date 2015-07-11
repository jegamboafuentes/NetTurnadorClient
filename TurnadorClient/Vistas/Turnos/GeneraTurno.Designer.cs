namespace TurnadorClient.Vistas
{
    partial class GeneraTurno
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
            this.lblGeneraTurno = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblUnidadNegocio = new System.Windows.Forms.Label();
            this.lblTurnoSeguimiento = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbUnidadNegocio = new System.Windows.Forms.ComboBox();
            this.txtTurnoSeguimiento = new System.Windows.Forms.TextBox();
            this.cmdGeneraTurno = new System.Windows.Forms.Button();
            this.radioButtonSencillo = new System.Windows.Forms.RadioButton();
            this.radioButtonAvanzado = new System.Windows.Forms.RadioButton();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblGeneraTurno
            // 
            this.lblGeneraTurno.AutoSize = true;
            this.lblGeneraTurno.Location = new System.Drawing.Point(12, 9);
            this.lblGeneraTurno.Name = "lblGeneraTurno";
            this.lblGeneraTurno.Size = new System.Drawing.Size(72, 13);
            this.lblGeneraTurno.TabIndex = 0;
            this.lblGeneraTurno.Text = "Generar turno";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(21, 50);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen";
            // 
            // lblUnidadNegocio
            // 
            this.lblUnidadNegocio.AutoSize = true;
            this.lblUnidadNegocio.Location = new System.Drawing.Point(21, 85);
            this.lblUnidadNegocio.Name = "lblUnidadNegocio";
            this.lblUnidadNegocio.Size = new System.Drawing.Size(99, 13);
            this.lblUnidadNegocio.TabIndex = 2;
            this.lblUnidadNegocio.Text = "Unidad de Negocio";
            // 
            // lblTurnoSeguimiento
            // 
            this.lblTurnoSeguimiento.AutoSize = true;
            this.lblTurnoSeguimiento.Location = new System.Drawing.Point(21, 116);
            this.lblTurnoSeguimiento.Name = "lblTurnoSeguimiento";
            this.lblTurnoSeguimiento.Size = new System.Drawing.Size(96, 13);
            this.lblTurnoSeguimiento.TabIndex = 3;
            this.lblTurnoSeguimiento.Text = "Turno Seguimiento";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbOrigen.Location = new System.Drawing.Point(151, 47);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 4;
            this.cmbOrigen.Text = "1";
            // 
            // cmbUnidadNegocio
            // 
            this.cmbUnidadNegocio.FormattingEnabled = true;
            this.cmbUnidadNegocio.Location = new System.Drawing.Point(151, 82);
            this.cmbUnidadNegocio.Name = "cmbUnidadNegocio";
            this.cmbUnidadNegocio.Size = new System.Drawing.Size(121, 21);
            this.cmbUnidadNegocio.TabIndex = 5;
            // 
            // txtTurnoSeguimiento
            // 
            this.txtTurnoSeguimiento.Location = new System.Drawing.Point(151, 116);
            this.txtTurnoSeguimiento.Name = "txtTurnoSeguimiento";
            this.txtTurnoSeguimiento.Size = new System.Drawing.Size(121, 20);
            this.txtTurnoSeguimiento.TabIndex = 6;
            this.txtTurnoSeguimiento.Text = "0";
            // 
            // cmdGeneraTurno
            // 
            this.cmdGeneraTurno.Location = new System.Drawing.Point(121, 186);
            this.cmdGeneraTurno.Name = "cmdGeneraTurno";
            this.cmdGeneraTurno.Size = new System.Drawing.Size(151, 51);
            this.cmdGeneraTurno.TabIndex = 7;
            this.cmdGeneraTurno.Text = "Turno";
            this.cmdGeneraTurno.UseVisualStyleBackColor = true;
            this.cmdGeneraTurno.Click += new System.EventHandler(this.cmdGeneraTurno_Click);
            // 
            // radioButtonSencillo
            // 
            this.radioButtonSencillo.AutoSize = true;
            this.radioButtonSencillo.Location = new System.Drawing.Point(15, 158);
            this.radioButtonSencillo.Name = "radioButtonSencillo";
            this.radioButtonSencillo.Size = new System.Drawing.Size(62, 17);
            this.radioButtonSencillo.TabIndex = 8;
            this.radioButtonSencillo.TabStop = true;
            this.radioButtonSencillo.Text = "Sencillo";
            this.radioButtonSencillo.UseVisualStyleBackColor = true;
            this.radioButtonSencillo.CheckedChanged += new System.EventHandler(this.radioButtonSencillo_CheckedChanged);
            // 
            // radioButtonAvanzado
            // 
            this.radioButtonAvanzado.AutoSize = true;
            this.radioButtonAvanzado.Location = new System.Drawing.Point(15, 181);
            this.radioButtonAvanzado.Name = "radioButtonAvanzado";
            this.radioButtonAvanzado.Size = new System.Drawing.Size(73, 17);
            this.radioButtonAvanzado.TabIndex = 9;
            this.radioButtonAvanzado.TabStop = true;
            this.radioButtonAvanzado.Text = "Avanzado";
            this.radioButtonAvanzado.UseVisualStyleBackColor = true;
            this.radioButtonAvanzado.CheckedChanged += new System.EventHandler(this.radioButtonAvanzado_CheckedChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(9, 201);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(99, 13);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad de turnos:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(8, 217);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(121, 243);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(151, 13);
            this.progressBar1.TabIndex = 12;
            // 
            // GeneraTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.radioButtonAvanzado);
            this.Controls.Add(this.radioButtonSencillo);
            this.Controls.Add(this.cmdGeneraTurno);
            this.Controls.Add(this.txtTurnoSeguimiento);
            this.Controls.Add(this.cmbUnidadNegocio);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.lblTurnoSeguimiento);
            this.Controls.Add(this.lblUnidadNegocio);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblGeneraTurno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneraTurno";
            this.Text = "GeneraTurno";
            this.Load += new System.EventHandler(this.GeneraTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeneraTurno;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblUnidadNegocio;
        private System.Windows.Forms.Label lblTurnoSeguimiento;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbUnidadNegocio;
        private System.Windows.Forms.TextBox txtTurnoSeguimiento;
        private System.Windows.Forms.Button cmdGeneraTurno;
        private System.Windows.Forms.RadioButton radioButtonSencillo;
        private System.Windows.Forms.RadioButton radioButtonAvanzado;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}