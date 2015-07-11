namespace TurnadorClient.Vistas.HappyPath
{
    partial class HappySencillo
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
        public void InitializeComponent()
        {
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblUnidadNegocio = new System.Windows.Forms.Label();
            this.lblCantidadTurnos = new System.Windows.Forms.Label();
            this.lblTiempoMinimo = new System.Windows.Forms.Label();
            this.lblTiempoMaximo = new System.Windows.Forms.Label();
            this.txtNoEmpleado = new System.Windows.Forms.TextBox();
            this.txtUnidadNegocio = new System.Windows.Forms.TextBox();
            this.txtCantidadTurnos = new System.Windows.Forms.TextBox();
            this.txtTiempoMinimo = new System.Windows.Forms.TextBox();
            this.txtTiempoMaximo = new System.Windows.Forms.TextBox();
            this.cmdEmpezar = new System.Windows.Forms.Button();
            this.cmdSmart = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTurno = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTurno = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelContador = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusContador = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(22, 21);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(57, 13);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblUnidadNegocio
            // 
            this.lblUnidadNegocio.AutoSize = true;
            this.lblUnidadNegocio.Location = new System.Drawing.Point(22, 51);
            this.lblUnidadNegocio.Name = "lblUnidadNegocio";
            this.lblUnidadNegocio.Size = new System.Drawing.Size(100, 13);
            this.lblUnidadNegocio.TabIndex = 1;
            this.lblUnidadNegocio.Text = "Unidad de negocio:";
            // 
            // lblCantidadTurnos
            // 
            this.lblCantidadTurnos.AutoSize = true;
            this.lblCantidadTurnos.Location = new System.Drawing.Point(22, 84);
            this.lblCantidadTurnos.Name = "lblCantidadTurnos";
            this.lblCantidadTurnos.Size = new System.Drawing.Size(99, 13);
            this.lblCantidadTurnos.TabIndex = 2;
            this.lblCantidadTurnos.Text = "Cantidad de turnos:";
            // 
            // lblTiempoMinimo
            // 
            this.lblTiempoMinimo.AutoSize = true;
            this.lblTiempoMinimo.Location = new System.Drawing.Point(22, 121);
            this.lblTiempoMinimo.Name = "lblTiempoMinimo";
            this.lblTiempoMinimo.Size = new System.Drawing.Size(165, 13);
            this.lblTiempoMinimo.TabIndex = 3;
            this.lblTiempoMinimo.Text = "Tiempo minimo de atencion: (seg)";
            // 
            // lblTiempoMaximo
            // 
            this.lblTiempoMaximo.AutoSize = true;
            this.lblTiempoMaximo.Location = new System.Drawing.Point(22, 155);
            this.lblTiempoMaximo.Name = "lblTiempoMaximo";
            this.lblTiempoMaximo.Size = new System.Drawing.Size(168, 13);
            this.lblTiempoMaximo.TabIndex = 4;
            this.lblTiempoMaximo.Text = "Tiempo maximo de atencion: (seg)";
            // 
            // txtNoEmpleado
            // 
            this.txtNoEmpleado.Location = new System.Drawing.Point(192, 18);
            this.txtNoEmpleado.Name = "txtNoEmpleado";
            this.txtNoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNoEmpleado.TabIndex = 5;
            // 
            // txtUnidadNegocio
            // 
            this.txtUnidadNegocio.Enabled = false;
            this.txtUnidadNegocio.Location = new System.Drawing.Point(192, 51);
            this.txtUnidadNegocio.Name = "txtUnidadNegocio";
            this.txtUnidadNegocio.Size = new System.Drawing.Size(100, 20);
            this.txtUnidadNegocio.TabIndex = 6;
            // 
            // txtCantidadTurnos
            // 
            this.txtCantidadTurnos.Location = new System.Drawing.Point(192, 84);
            this.txtCantidadTurnos.Name = "txtCantidadTurnos";
            this.txtCantidadTurnos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadTurnos.TabIndex = 7;
            // 
            // txtTiempoMinimo
            // 
            this.txtTiempoMinimo.Location = new System.Drawing.Point(192, 118);
            this.txtTiempoMinimo.Name = "txtTiempoMinimo";
            this.txtTiempoMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoMinimo.TabIndex = 8;
            // 
            // txtTiempoMaximo
            // 
            this.txtTiempoMaximo.Location = new System.Drawing.Point(192, 155);
            this.txtTiempoMaximo.Name = "txtTiempoMaximo";
            this.txtTiempoMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoMaximo.TabIndex = 9;
            // 
            // cmdEmpezar
            // 
            this.cmdEmpezar.Location = new System.Drawing.Point(210, 190);
            this.cmdEmpezar.Name = "cmdEmpezar";
            this.cmdEmpezar.Size = new System.Drawing.Size(75, 23);
            this.cmdEmpezar.TabIndex = 10;
            this.cmdEmpezar.Text = "Empezar";
            this.cmdEmpezar.UseVisualStyleBackColor = true;
            this.cmdEmpezar.Click += new System.EventHandler(this.cmdEmpezar_Click);
            // 
            // cmdSmart
            // 
            this.cmdSmart.Location = new System.Drawing.Point(298, 17);
            this.cmdSmart.Name = "cmdSmart";
            this.cmdSmart.Size = new System.Drawing.Size(19, 20);
            this.cmdSmart.TabIndex = 11;
            this.cmdSmart.Text = "•";
            this.cmdSmart.UseVisualStyleBackColor = true;
            this.cmdSmart.Click += new System.EventHandler(this.cmdSmart_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(123, 190);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 13;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTurno,
            this.toolStripStatusTurno,
            this.toolStripStatusLabelTime,
            this.toolStripStatusTime,
            this.toolStripStatusLabelContador,
            this.toolStripStatusContador});
            this.statusStrip1.Location = new System.Drawing.Point(0, 227);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(323, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTurno
            // 
            this.toolStripStatusLabelTurno.Name = "toolStripStatusLabelTurno";
            this.toolStripStatusLabelTurno.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelTurno.Text = "Turno:";
            // 
            // toolStripStatusTurno
            // 
            this.toolStripStatusTurno.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.toolStripStatusTurno.Name = "toolStripStatusTurno";
            this.toolStripStatusTurno.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusTurno.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusTurno.Text = "--";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabelTime.Text = "Tiempo:";
            // 
            // toolStripStatusTime
            // 
            this.toolStripStatusTime.Name = "toolStripStatusTime";
            this.toolStripStatusTime.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusTime.Text = "--";
            // 
            // toolStripStatusLabelContador
            // 
            this.toolStripStatusLabelContador.Name = "toolStripStatusLabelContador";
            this.toolStripStatusLabelContador.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabelContador.Text = "Contador:";
            // 
            // toolStripStatusContador
            // 
            this.toolStripStatusContador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripStatusContador.Name = "toolStripStatusContador";
            this.toolStripStatusContador.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusContador.Text = "--";
            // 
            // HappySencillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 249);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdSmart);
            this.Controls.Add(this.cmdEmpezar);
            this.Controls.Add(this.txtTiempoMaximo);
            this.Controls.Add(this.txtTiempoMinimo);
            this.Controls.Add(this.txtCantidadTurnos);
            this.Controls.Add(this.txtUnidadNegocio);
            this.Controls.Add(this.txtNoEmpleado);
            this.Controls.Add(this.lblTiempoMaximo);
            this.Controls.Add(this.lblTiempoMinimo);
            this.Controls.Add(this.lblCantidadTurnos);
            this.Controls.Add(this.lblUnidadNegocio);
            this.Controls.Add(this.lblEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HappySencillo";
            this.Text = "Happy Sencillo";
            this.Load += new System.EventHandler(this.HappySencillo_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblUnidadNegocio;
        private System.Windows.Forms.Label lblCantidadTurnos;
        private System.Windows.Forms.Label lblTiempoMinimo;
        private System.Windows.Forms.Label lblTiempoMaximo;
        private System.Windows.Forms.TextBox txtNoEmpleado;
        private System.Windows.Forms.TextBox txtUnidadNegocio;
        private System.Windows.Forms.TextBox txtCantidadTurnos;
        private System.Windows.Forms.TextBox txtTiempoMinimo;
        private System.Windows.Forms.TextBox txtTiempoMaximo;
        private System.Windows.Forms.Button cmdEmpezar;
        private System.Windows.Forms.Button cmdSmart;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTurno;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTurno;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelContador;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusContador;
    }
}