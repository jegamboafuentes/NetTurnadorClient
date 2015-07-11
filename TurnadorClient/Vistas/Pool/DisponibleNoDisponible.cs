using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TurnadorClient.Logica;
using TurnadorClient.Model;
using TurnadorClient.Util;

namespace TurnadorClient.Vistas.Pool
{
    public partial class DisponibleNoDisponible : Form
    {
        PoolService oPoolService = new PoolService();
        Utilidades oUtilidades = new Utilidades();

        public DisponibleNoDisponible()
        {
            InitializeComponent();
        }

        private void DisponibleNoDisponible_Load(object sender, EventArgs e)
        {
            if (oUtilidades.configuracion() == false)
            {
                this.Close();
            }
            else
            {
                NoDisponible();
            }
            
        }

        private void cmdAccion_Click(object sender, EventArgs e)
        {
            string noempleado = txtNoEmpleado.Text;
            if (radioButtonNoDisponible.Checked == true)
            {
                oPoolService.SetNoDisponible(noempleado,0);
            }
            else
            {
                oPoolService.SetDisponible(noempleado,0);
            }
        }

        public void NoDisponible()
        {
            if (radioButtonDisponible.Checked == true)
            {
                radioButtonDisponible.Checked = false;
            }
            else
            {
                radioButtonNoDisponible.Checked = true;
                cmdAccion.Text = "No disponible";
            }
        }

        public void Disponible()
        {
            if (radioButtonNoDisponible.Checked == true)
            {
                radioButtonNoDisponible.Checked = false;
            }
            else
            {
                radioButtonDisponible.Checked = true;
                cmdAccion.Text = "Disponible";
            }
        }

        private void radioButtonNoDisponible_CheckedChanged(object sender, EventArgs e)
        {
            NoDisponible();
        }

        private void radioButtonDisponible_CheckedChanged(object sender, EventArgs e)
        {
            Disponible();
        }
    }
}
