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

namespace TurnadorClient.Vistas
{
    public partial class GeneraTurno : Form
    {

        TurnosService oTurnosService = new TurnosService();
        NegocioService oNegocioService = new NegocioService();
        Turno oTurno = new Turno();
        Utilidades oUtilidades = new Utilidades();
        int tipo = 0; // Sencillo = 0, Avanzado = 1

        private void GeneraTurno_Load(object sender, EventArgs e)
        {
            if (oUtilidades.configuracion() == false)
            {
                this.Close();
            }
            else
            {
                llenaUnidadNegocio();
                sencillo();
            }          
        }

        public GeneraTurno()
        {
            InitializeComponent();
        }

        private void cmdGeneraTurno_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 0:
                    {
                        oTurnosService.GeneraTurno(cmbOrigen.SelectedItem.ToString(), cmbUnidadNegocio.SelectedItem.ToString(), txtTurnoSeguimiento.Text,0);
                        break;
                    }
                case 1:
                    {
                        try
                        {
                            progressBar1.Maximum = Int32.Parse(txtCantidad.Text);
                            for (int i = 1; i <= Int32.Parse(txtCantidad.Text); i++)
                            {
                                oTurnosService.GeneraTurno(cmbOrigen.SelectedItem.ToString(), cmbUnidadNegocio.SelectedItem.ToString(), txtTurnoSeguimiento.Text,1);
                                progressBar1.Value = i;
                            }
                            MessageBox.Show(Int32.Parse(txtCantidad.Text) + " Turnos generados", "Turno");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error al generar turnos consecutivamente");
                        }
                        break;
                    }
            }

            

        }

        public void sencillo()
        {
            if (radioButtonAvanzado.Checked == true)
            {
                radioButtonAvanzado.Checked = false;
            }
            else
            {
                radioButtonSencillo.Checked = true;
            }
            lblCantidad.Visible = false;
            txtCantidad.Visible = false;
            progressBar1.Visible = false;
            cmdGeneraTurno.Text = "Turno";
            tipo = 0;

        }

        public void avanzado()
        {
            if (radioButtonSencillo.Checked == true)
            {
                radioButtonSencillo.Checked = false;
            }
            else
            {
                radioButtonAvanzado.Checked = true;
            }
            lblCantidad.Visible = true;
            txtCantidad.Visible = true;
            progressBar1.Visible = true;
            cmdGeneraTurno.Text = "Generar turnos";
            tipo = 1;
        }

        public void llenaUnidadNegocio()
        {
            NegocioService oNegocioService = new NegocioService();
            System.Object[] ItemObject = new System.Object[oNegocioService.GetUnidadesNegocioId().Length];
            for (int i = 0; i < oNegocioService.GetUnidadesNegocioId().Length; i++)
            {
                ItemObject[i] = oNegocioService.GetUnidadesNegocioId()[i];
            }
            cmbUnidadNegocio.Items.AddRange(ItemObject);
            List<int> lst = ItemObject.OfType<int>().ToList();
            cmbUnidadNegocio.Text = lst.Min().ToString();

        }

        private void radioButtonSencillo_CheckedChanged(object sender, EventArgs e)
        {
            sencillo();
        }

        private void radioButtonAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            avanzado();
        }


    }
}
