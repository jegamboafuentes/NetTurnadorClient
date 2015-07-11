using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TurnadorClient.Logica;

namespace TurnadorClient.Vistas.Pool
{
    public partial class Registra_punto_atencion : Form
    {
        PoolService oPoolService = new PoolService();

        public Registra_punto_atencion()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            String noEmpleado = txtNoEmpleado.Text;
            String puntoAtencion = txtPuntoAtencion.Text;
            oPoolService.SetPuntoAtencion(noEmpleado, puntoAtencion,0);
        }
    }
}
