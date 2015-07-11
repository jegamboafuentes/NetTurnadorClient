using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurnadorClient.Vistas.HappyPath
{
    public partial class Configuracion0 : Form
    {
        private int opcion;
        public Configuracion0()
        {
            InitializeComponent();
        }

        private void Configuracion0_Load(object sender, EventArgs e)
        {
            radioButtonAvanzado.Enabled = false;
        }

        private void radioButtonSencillo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAvanzado.Checked == true)
            {
                radioButtonAvanzado.Checked = false;
                radioButtonSencillo.Checked = true;
                opcion = 0;
            }
        }

        private void radioButtonAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSencillo.Checked == true)
            {
                radioButtonSencillo.Checked = false;
                radioButtonAvanzado.Checked = true;
                opcion = 1;
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case 0:
                    {
                        HappySencillo oHappySencillo = new HappySencillo();
                        oHappySencillo.Show();
                        break;
                    }
                case 1:
                    {
                        break;
                    }
            }
        }
    }
}
