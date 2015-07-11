using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

using TurnadorClient.Logica;
using TurnadorClient.Model;
using TurnadorClient.Vistas.Pool;
using TurnadorClient.Vistas.Turnos;
using TurnadorClient.Vistas.HappyPath;
using TurnadorClient.Vistas.Virtual;

namespace TurnadorClient.Vistas
{
    public partial class Principal : Form
    {
        public static string SERVIDOR {get; set;}
        public static bool PRODUCCION { get; set; }
        public static bool DISPLAY { get; set; }

        NegocioService oNegocioService = new NegocioService();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            SERVIDOR = "http://nt0055/BazCajaFront/Servicios/Turnador/";
            //SERVIDOR = "http://10.51.214.230:9999/BazCajaFront/Servicios/Turnador/";
            Monitor();
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
            Monitor();
        }

        #region BarraMenus

        private void generarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneraTurno ventanaTurno = new GeneraTurno();
            ventanaTurno.Show();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion oConfig = new Configuracion();
            oConfig.Show();
        }

        private void obtenerUnidadDeNegocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetUnidadNegocio getUnidadNegocio = new GetUnidadNegocio();
            getUnidadNegocio.Show();
        }

        private void noDisponibleDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisponibleNoDisponible oDisponibleNodisponible = new DisponibleNoDisponible();
            oDisponibleNodisponible.Show();
        }

        private void atenderTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtenderTurno oAtenderTurno = new AtenderTurno();
            oAtenderTurno.Show();
        }

        private void finalizarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalizarTurno oFinalizarTurno = new FinalizarTurno();
            oFinalizarTurno.Show();
        }

        private void registraPuntoDeAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registra_punto_atencion oRegistraPuntoAtencion = new Registra_punto_atencion();
            oRegistraPuntoAtencion.Show();
        }

        private void posponerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posponer oPosponer = new Posponer();
            oPosponer.Show();
        }

        private void virtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Turnos.Virtual oVirtual = new Turnos.Virtual();
            oVirtual.Show();
        }

        private void happyPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion0 oConfiguracion0 = new Configuracion0();
            MustraDisplay(DISPLAY);
            oConfiguracion0.Show();
        }

        private void atencionTurnosVirtualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtencionTurnosVirtuales oAtencionTurnosVirtuales = new AtencionTurnosVirtuales();
            oAtencionTurnosVirtuales.Show();
        }

        #endregion // ------------------------------------------------------------------------- END REGION

        private void cmdHappyPath_Click(object sender, EventArgs e)
        {
            Configuracion0 oConfiguracion0 = new Configuracion0();
            MustraDisplay(DISPLAY);
            oConfiguracion0.Show();
        }

        private void Monitor()
        {
            toolStripStatusServidor.Text = ServidorConectado();
            if (DISPLAY == true)
            {
                toolStripStatusDisplay.Text = "on";
            }
            else
            {
                toolStripStatusDisplay.Text = "off";
            }
            //if (StatusConexion(SERVIDOR) == 200)
            //{
            //    toolStripStatusPrueba.ForeColor = System.Drawing.Color.Green;
            //}
            //else
            //{
            //    toolStripStatusPrueba.ForeColor = System.Drawing.Color.Red;
            //}
        }
        private string ServidorConectado()
        {
            string servidor = SERVIDOR;
            bool re;
            string ouput;

            re = servidor.Contains("localhost");
            if (re == true)
            {

                int startIndex = servidor.IndexOf("/") + 2;
                int length = servidor.IndexOf("/", startIndex) - startIndex;
                ouput = servidor.Substring(startIndex, length).Trim();
            }
            else
            {
                int startIndex = servidor.IndexOf("/") + 2;
                int length = servidor.IndexOf("/", startIndex) - startIndex;
                //int length = servidor.IndexOf("/BazCajaFront/Servicios/Turnador/", startIndex) - startIndex;
                ouput = servidor.Substring(startIndex, length).Trim();
            }
            return ouput;  
        }
        private int StatusConexion(string servidorFullDirection)
        {
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(servidorFullDirection + "CjCRTurnosService.svc");
            httpReq.Proxy = null;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.DefaultConnectionLimit = 1;
            httpReq.AllowAutoRedirect = false;
            try
            {
                HttpWebResponse httpRes = (HttpWebResponse)httpReq.GetResponse();
                return (int)httpRes.StatusCode;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        private void MustraDisplay(bool display)
        {
            if (display == true)
            {
                Display oDisplay = new Display();
                oDisplay.Show();
            }
        }

        

        

        

        

    }
}
