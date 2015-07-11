using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TurnadorClient;

namespace TurnadorClient.Vistas
{
    public partial class Configuracion : Form
    {
        Principal oPrincipal = new Principal();

        public Configuracion()
        {
            InitializeComponent();
            radioButtonProduccion.Checked = true;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            //oPrincipal.servidorForm = txtServidor.Text;
            if (radioButtonProduccion.Checked == true)
            {
                Principal.SERVIDOR = txtServidor.Text;
            }
            else 
            {
                Principal.SERVIDOR = "http://localhost:"+txtServidor.Text+"/";
            }
            oPrincipal.toolStripStatusServidor.Text = Principal.SERVIDOR;
            Display();
            this.Close();
        }

        private void Desarrollo()
        {
            if (radioButtonDesarrollo.Checked == true)
            {
                radioButtonProduccion.Checked = false;
                checkBoxNt.Visible = false;
                lblServidor.Text = "localhost puerto:";
                lblEjemplo.Text = "";
                txtServidor.Text = "8888";

            }
        }

        private void Produccion()
        {
            if (radioButtonProduccion.Checked == true)
            {
                radioButtonDesarrollo.Checked = false;
                checkBoxNt.Visible = true;
                lblServidor.Text = "Servidor:";
                lblEjemplo.Text = "Escribe el numero de el servidor con ceros, ejemplo: 0055";
                txtServidor.Text = "";
            }
        }


        private void Display()
        {
            if (checkBoxDisplay.Checked == true)
            {
                Principal.DISPLAY = true;
            }
            else
            {
                Principal.DISPLAY = false;
            }
        }

        private void radioButtonProduccion_CheckedChanged(object sender, EventArgs e)
        {
            Desarrollo();
        }

        private void radioButtonDesarrollo_CheckedChanged(object sender, EventArgs e)
        {
            Produccion();
        }

        private void checkBoxNt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNt.Checked == true)
            {
                txtServidor.Text = "http://nt/BazCajaFront/Servicios/Turnador/";
                lblEjemplo.Text = "Escribe el numero de el servidor con ceros, ejemplo: 0055";
            }
            else
            {
                txtServidor.Text = "";
                lblEjemplo.Text = "Escribe la direccion del servidor, ejemplo: http://miservidor/servicio/ ";
            }
        }




    }
}
