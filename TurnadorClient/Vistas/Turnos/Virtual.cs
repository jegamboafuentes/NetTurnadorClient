using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TurnadorClient.Logica;

namespace TurnadorClient.Vistas.Turnos
{
    public partial class Virtual : Form
    {
        PoolService oLogicPoolService = new PoolService();
        TurnosService oLogicTurnosService = new TurnosService();

        public Virtual()
        {
            InitializeComponent();
        }

        private void Virtual_Load(object sender, EventArgs e)
        {

        }

        private void cmdSmart_Click_1(object sender, EventArgs e)
        {
            if (txtNoEmpleado.Text.Length != 6)
            {
                MessageBox.Show("El numero de empleado es incorrecto", "Error");
            }
            else
            {
                string empleado = txtNoEmpleado.Text;
                txtUnidadNegocio.Text = oLogicPoolService.ConsultaUnidadNegocio(empleado).IdUnidadNegocio.ToString();
            }
        }

        private void txtNoEmpelado_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdGenerarVirtual_Click(object sender, EventArgs e)
        {
            string noEmpleado = txtNoEmpleado.Text;
            string idUnidadNegocio = txtUnidadNegocio.Text;
            oLogicTurnosService.AtiendeTurnoVirtual(noEmpleado, idUnidadNegocio,0);
        }
    }
}
