namespace TurnadorClient.Vistas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atenderTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posponerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virtualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerUnidadDeNegocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noDisponibleDisponibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registraPuntoDeAtencionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contingenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flujosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.happyPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClienteTurnos = new System.Windows.Forms.Label();
            this.cmdHappyPath = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelServidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusServidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.atencionTurnosVirtualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.poolToolStripMenuItem,
            this.poolToolStripMenuItem1,
            this.contingenciaToolStripMenuItem,
            this.flujosToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarTurnoToolStripMenuItem,
            this.atenderTurnoToolStripMenuItem,
            this.finalizarTurnoToolStripMenuItem,
            this.posponerToolStripMenuItem,
            this.virtualToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem1.Text = "Turnos";
            // 
            // generarTurnoToolStripMenuItem
            // 
            this.generarTurnoToolStripMenuItem.Name = "generarTurnoToolStripMenuItem";
            this.generarTurnoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.generarTurnoToolStripMenuItem.Text = "Generar turno";
            this.generarTurnoToolStripMenuItem.Click += new System.EventHandler(this.generarTurnoToolStripMenuItem_Click);
            // 
            // atenderTurnoToolStripMenuItem
            // 
            this.atenderTurnoToolStripMenuItem.Name = "atenderTurnoToolStripMenuItem";
            this.atenderTurnoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.atenderTurnoToolStripMenuItem.Text = "Atender turno";
            this.atenderTurnoToolStripMenuItem.Click += new System.EventHandler(this.atenderTurnoToolStripMenuItem_Click);
            // 
            // finalizarTurnoToolStripMenuItem
            // 
            this.finalizarTurnoToolStripMenuItem.Name = "finalizarTurnoToolStripMenuItem";
            this.finalizarTurnoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.finalizarTurnoToolStripMenuItem.Text = "Finalizar turno";
            this.finalizarTurnoToolStripMenuItem.Click += new System.EventHandler(this.finalizarTurnoToolStripMenuItem_Click);
            // 
            // posponerToolStripMenuItem
            // 
            this.posponerToolStripMenuItem.Name = "posponerToolStripMenuItem";
            this.posponerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.posponerToolStripMenuItem.Text = "Posponer";
            this.posponerToolStripMenuItem.Click += new System.EventHandler(this.posponerToolStripMenuItem_Click);
            // 
            // virtualToolStripMenuItem
            // 
            this.virtualToolStripMenuItem.Name = "virtualToolStripMenuItem";
            this.virtualToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.virtualToolStripMenuItem.Text = "Virtual";
            this.virtualToolStripMenuItem.Click += new System.EventHandler(this.virtualToolStripMenuItem_Click);
            // 
            // poolToolStripMenuItem
            // 
            this.poolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obtenerUnidadDeNegocioToolStripMenuItem});
            this.poolToolStripMenuItem.Name = "poolToolStripMenuItem";
            this.poolToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.poolToolStripMenuItem.Text = "Negocio";
            // 
            // obtenerUnidadDeNegocioToolStripMenuItem
            // 
            this.obtenerUnidadDeNegocioToolStripMenuItem.Name = "obtenerUnidadDeNegocioToolStripMenuItem";
            this.obtenerUnidadDeNegocioToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.obtenerUnidadDeNegocioToolStripMenuItem.Text = "Obtener unidades de negocio";
            this.obtenerUnidadDeNegocioToolStripMenuItem.Click += new System.EventHandler(this.obtenerUnidadDeNegocioToolStripMenuItem_Click);
            // 
            // poolToolStripMenuItem1
            // 
            this.poolToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noDisponibleDisponibleToolStripMenuItem,
            this.registraPuntoDeAtencionToolStripMenuItem});
            this.poolToolStripMenuItem1.Name = "poolToolStripMenuItem1";
            this.poolToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.poolToolStripMenuItem1.Text = "Pool";
            // 
            // noDisponibleDisponibleToolStripMenuItem
            // 
            this.noDisponibleDisponibleToolStripMenuItem.Name = "noDisponibleDisponibleToolStripMenuItem";
            this.noDisponibleDisponibleToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.noDisponibleDisponibleToolStripMenuItem.Text = "No disponible / Disponible";
            this.noDisponibleDisponibleToolStripMenuItem.Click += new System.EventHandler(this.noDisponibleDisponibleToolStripMenuItem_Click);
            // 
            // registraPuntoDeAtencionToolStripMenuItem
            // 
            this.registraPuntoDeAtencionToolStripMenuItem.Name = "registraPuntoDeAtencionToolStripMenuItem";
            this.registraPuntoDeAtencionToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.registraPuntoDeAtencionToolStripMenuItem.Text = "Registra punto de atencion";
            this.registraPuntoDeAtencionToolStripMenuItem.Click += new System.EventHandler(this.registraPuntoDeAtencionToolStripMenuItem_Click);
            // 
            // contingenciaToolStripMenuItem
            // 
            this.contingenciaToolStripMenuItem.Name = "contingenciaToolStripMenuItem";
            this.contingenciaToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.contingenciaToolStripMenuItem.Text = "Contingencia";
            // 
            // flujosToolStripMenuItem
            // 
            this.flujosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.happyPathToolStripMenuItem,
            this.atencionTurnosVirtualesToolStripMenuItem});
            this.flujosToolStripMenuItem.Name = "flujosToolStripMenuItem";
            this.flujosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.flujosToolStripMenuItem.Text = "Flujos";
            // 
            // happyPathToolStripMenuItem
            // 
            this.happyPathToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("happyPathToolStripMenuItem.Image")));
            this.happyPathToolStripMenuItem.Name = "happyPathToolStripMenuItem";
            this.happyPathToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.happyPathToolStripMenuItem.Text = "Happy Path";
            this.happyPathToolStripMenuItem.Click += new System.EventHandler(this.happyPathToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // lblClienteTurnos
            // 
            this.lblClienteTurnos.AutoSize = true;
            this.lblClienteTurnos.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteTurnos.Location = new System.Drawing.Point(168, 55);
            this.lblClienteTurnos.Name = "lblClienteTurnos";
            this.lblClienteTurnos.Size = new System.Drawing.Size(179, 30);
            this.lblClienteTurnos.TabIndex = 2;
            this.lblClienteTurnos.Text = "Cliente turnador";
            // 
            // cmdHappyPath
            // 
            this.cmdHappyPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdHappyPath.BackgroundImage")));
            this.cmdHappyPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdHappyPath.Location = new System.Drawing.Point(224, 88);
            this.cmdHappyPath.Name = "cmdHappyPath";
            this.cmdHappyPath.Size = new System.Drawing.Size(62, 61);
            this.cmdHappyPath.TabIndex = 3;
            this.cmdHappyPath.UseVisualStyleBackColor = true;
            this.cmdHappyPath.Click += new System.EventHandler(this.cmdHappyPath_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelServidor,
            this.toolStripStatusServidor,
            this.toolStripStatusLabelDisplay,
            this.toolStripStatusDisplay});
            this.statusStrip1.Location = new System.Drawing.Point(0, 174);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(488, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelServidor
            // 
            this.toolStripStatusLabelServidor.Name = "toolStripStatusLabelServidor";
            this.toolStripStatusLabelServidor.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabelServidor.Text = "Conectado:";
            // 
            // toolStripStatusServidor
            // 
            this.toolStripStatusServidor.Name = "toolStripStatusServidor";
            this.toolStripStatusServidor.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusServidor.Text = "--";
            // 
            // toolStripStatusLabelDisplay
            // 
            this.toolStripStatusLabelDisplay.Name = "toolStripStatusLabelDisplay";
            this.toolStripStatusLabelDisplay.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabelDisplay.Text = "Display:";
            // 
            // toolStripStatusDisplay
            // 
            this.toolStripStatusDisplay.Name = "toolStripStatusDisplay";
            this.toolStripStatusDisplay.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusDisplay.Text = "--";
            // 
            // atencionTurnosVirtualesToolStripMenuItem
            // 
            this.atencionTurnosVirtualesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atencionTurnosVirtualesToolStripMenuItem.Image")));
            this.atencionTurnosVirtualesToolStripMenuItem.Name = "atencionTurnosVirtualesToolStripMenuItem";
            this.atencionTurnosVirtualesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.atencionTurnosVirtualesToolStripMenuItem.Text = "Atencion turnos virtuales";
            this.atencionTurnosVirtualesToolStripMenuItem.Click += new System.EventHandler(this.atencionTurnosVirtualesToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 196);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdHappyPath);
            this.Controls.Add(this.lblClienteTurnos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Activated += new System.EventHandler(this.Principal_Activated);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poolToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contingenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.Label lblClienteTurnos;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerUnidadDeNegocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noDisponibleDisponibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atenderTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registraPuntoDeAtencionToolStripMenuItem;
        private System.Windows.Forms.Button cmdHappyPath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelServidor;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusServidor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDisplay;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDisplay;
        private System.Windows.Forms.ToolStripMenuItem posponerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virtualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flujosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem happyPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atencionTurnosVirtualesToolStripMenuItem;
    }
}