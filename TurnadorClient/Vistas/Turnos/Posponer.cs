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

namespace TurnadorClient.Vistas.Turnos
{
    public partial class Posponer : Form
    {
        Utilidades oUtilidades = new Utilidades();
        TurnosService oTurnosService = new TurnosService();
        public Posponer()
        {
            InitializeComponent();
        }

        private void Posponer_Load(object sender, EventArgs e)
        {
            if (oUtilidades.configuracion() == false)
            {
                this.Close();
            }
            else
            {
                txtFecha.Text = oUtilidades.getFecha();
                llenaUnidadNegocio();
            } 
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

        private void cmdPosponer_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idTurno = txtTurno.Text;
            string idUnidadNegocio = cmbUnidadNegocio.SelectedItem.ToString();
            oTurnosService.PosponerTurno(fecha, idTurno, idUnidadNegocio, 0);
            
        }
    }
}
