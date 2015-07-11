using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


using TurnadorClient.Logica;
using TurnadorClient.Model;
using TurnadorClient.Util;


namespace TurnadorClient.Vistas.HappyPath
{
    public partial class HappySencillo : Form
    {
        private Thread oThread = null;

        Utilidades oUtilidades = new Utilidades();

        Logica.HappyPath oHappyPath = new Logica.HappyPath();

        TurnosService oTurnosService = new TurnosService();
        PoolService oPoolService = new PoolService();

        Empleado oEmpleado = new Empleado();
        Turno oTurno = new Turno();

        public HappySencillo()
        {
            InitializeComponent();
        }

        private void cmdEmpezar_Click(object sender, EventArgs e)
        {
            if (ValidaTextBox() == true)
            {
                cmdCancelar.Enabled = true;
                toolStripStatusContador.Text = "--";
                toolStripStatusTime.Text = "--";
                string noEmpleado = txtNoEmpleado.Text;
                string idUnidadNegocio = txtUnidadNegocio.Text;
                string cantidadTurnos = txtCantidadTurnos.Text;
                this.oThread = new Thread(new ThreadStart(this.instancia));
                oThread.Name = "TR LogicaHappyPath";
                oThread.IsBackground = true;
                oThread.Start();
                //progressBar1.Maximum = Int32.Parse(cantidadTurnos);
                backgroundWorker1.RunWorkerAsync();

                //do
                //{
                //    value++;
                //} while (oHappyPath.turnosTotal != 40);
                //Thread.Sleep(5000);
                //for (int i = 0; i < 500; i++)
                //{
                //    toolStripProgressBar1.Value = i;
                //}
            }
        }

        public void instancia()
        {
            string noEmpleado = txtNoEmpleado.Text;
            string idUnidadNegocio = txtUnidadNegocio.Text;
            string cantidadTurnos = txtCantidadTurnos.Text;
            int tiempoMinimo = Int32.Parse(txtTiempoMinimo.Text);
            int tiempoMaximo = Int32.Parse(txtTiempoMaximo.Text);
            oHappyPath.HappySencillo(noEmpleado, idUnidadNegocio, cantidadTurnos,tiempoMinimo,tiempoMaximo);
        }

        private void cmdSmart_Click(object sender, EventArgs e)
        {
            string noEmpleado = txtNoEmpleado.Text;
            oEmpleado = oPoolService.ConsultaUnidadNegocio(noEmpleado);
            int idUnidadNegocio = oEmpleado.IdUnidadNegocio;
            txtUnidadNegocio.Text = idUnidadNegocio.ToString();
            if (idUnidadNegocio == 0)
            {
                oPoolService.SetNoDisponible(noEmpleado, 1);
                oEmpleado = oPoolService.ConsultaUnidadNegocio(noEmpleado);
                int idUnidadNegocio1 = oEmpleado.IdUnidadNegocio;
                txtUnidadNegocio.Text = idUnidadNegocio1.ToString();
                if (idUnidadNegocio1 == 0)
                {
                    MessageBox.Show("Este empleado no puede ingresar al pool", "Empleado incorrecto");
                }
                else
                    MessageBox.Show("El empleado " + noEmpleado + " se registro en el pool", "Happy Path");

            }
            else
            {
                txtCantidadTurnos.Text = "1";
                txtTiempoMinimo.Text = "0";
                txtTiempoMaximo.Text = "1";
            }

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (oThread.IsAlive == true)
            {
                oThread.Abort();
                cmdCancelar.Enabled = false;
            }
        }

        private void HappySencillo_Load(object sender, EventArgs e)
        {
            cmdCancelar.Enabled = false;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        public Boolean ValidaTextBox()
        {
            if (txtCantidadTurnos.Text == "" || txtNoEmpleado.Text == "" || txtTiempoMaximo.Text == "" ||txtTiempoMinimo.Text == "" || txtUnidadNegocio.Text=="")
            {
                MessageBox.Show("Debes de llenar todos los campos");
                return false;
            }
            int tiempMin = Int32.Parse(txtTiempoMinimo.Text);
            int tiempMax = Int32.Parse(txtTiempoMaximo.Text);
            if (tiempMin > tiempMax)
            {
                MessageBox.Show("El tiempo minimo no puede ser mayor al maximo");
                return false;
            }
            return true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            do{
                if (oThread.IsAlive)
                {
                    toolStripStatusTurno.Text = oHappyPath.idTurnoFlow;
                    toolStripStatusTime.Text = oHappyPath.tiempoEspera;
                    toolStripStatusContador.Text = oHappyPath.turnosTotalValue.ToString();
            //        this.progressBar1.BeginInvoke(
            //            (MethodInvoker)delegate()
            //        {
            //            progressBar1.Value = oHappyPath.turnosTotal;
            //            progressBar1.Refresh();
            //        });
                }
            }while(oThread.IsAlive);
            //this.progressBar1.BeginInvoke(
            //    (MethodInvoker)delegate()
            //    {
            //        progressBar1.Value = 0;
            //        progressBar1.Refresh();
            //    });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusTime.Text = DateTime.Now.ToString();
        }









    }
}
