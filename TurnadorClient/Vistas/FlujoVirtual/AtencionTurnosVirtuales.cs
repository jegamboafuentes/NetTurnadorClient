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

namespace TurnadorClient.Vistas.Virtual
{
    public partial class AtencionTurnosVirtuales : Form
    {
        FlujoVirtual oFlujoVirtual = new FlujoVirtual();

        private Thread oThread = null;

        public AtencionTurnosVirtuales()
        {
            InitializeComponent();
        }

        private void AtencionTurnosVirtuales_Load(object sender, EventArgs e)
        {
            cargaElementos();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void cargaElementos()
        {
            txtMin.Text = 1+"";
            txtMax.Text = 5+"";
            txtCantidad.Text = 1 + "";
        }

        private void cmdVirtual_Click(object sender, EventArgs e)
        {
            this.oThread = new Thread(new ThreadStart(this.instancia));
            oThread.Name = " TR Flujo Virtual";
            oThread.IsBackground = true;
            oThread.Start();
            backgroundWorker1.RunWorkerAsync();
        }

        private void instancia()
        {
            string empleado = txtnoEmpleado.Text;
            int tiempoMinimo = Int32.Parse(txtMin.Text);
            int tiempoMaximo = Int32.Parse(txtMax.Text);
            int cantidadDeTurnos = Int32.Parse(txtCantidad.Text);
            for (int i = 0; i < cantidadDeTurnos; i++)
            {
                oFlujoVirtual.flujoTurnoVirtual(empleado, tiempoMinimo, tiempoMaximo);
            }
            
            MessageBox.Show("Se completo el flujo " + cantidadDeTurnos + " veces exitosamente");
        }
    }
}
