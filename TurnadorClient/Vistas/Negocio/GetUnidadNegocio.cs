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
    public partial class GetUnidadNegocio : Form
    {
        NegocioService oNegocioService = new NegocioService();
        Negocio unidadDeNegocio = new Negocio();
        Utilidades oUtilidades = new Utilidades();

        public GetUnidadNegocio()
        {
            InitializeComponent();
        }

        private void GetUnidadNegocio_Load(object sender, EventArgs e)
        {
            if (oUtilidades.configuracion() == false)
            {
                this.Close();
            }
            else
            {
                llenaUnidadNegocio();
            }    

        }

        public void llenaUnidadNegocio()
        {
            lblUnidadesNegocio.Text = oNegocioService.GetUnidadesNegocio().Length.ToString();
            System.Object[] ItemObject = new System.Object[oNegocioService.GetUnidadesNegocioDescripcion().Length];
            for (int i = 0; i < oNegocioService.GetUnidadesNegocioDescripcion().Length; i++)
            {
                ItemObject[i] = oNegocioService.GetUnidadesNegocioDescripcion()[i];
            }
            cmbUnidadesNegocioNombre.Items.AddRange(ItemObject);
            List<String> lst = ItemObject.OfType<String>().ToList();
            cmbUnidadesNegocioNombre.Text = lst.Min().ToString();

        }

        public void seleccionaDatosUnidadNegocio()
        {

            System.Object[] ItemObject = new System.Object[oNegocioService.GetUnidadesNegocio().Length];
            Negocio[] unidadesDeNegocio = new Negocio[oNegocioService.GetUnidadesNegocio().Length];
            for (int i = 0; i < oNegocioService.GetUnidadesNegocio().Length; i++)
            {
                unidadesDeNegocio[i] = oNegocioService.GetUnidadesNegocio()[i];
                string selectedItem = cmbUnidadesNegocioNombre.SelectedItem.ToString();
                if (unidadesDeNegocio[i].Descripcion == selectedItem)
                {
                    lblColor.Text = unidadesDeNegocio[i].Color;
                    lblDescripcion.Text = unidadesDeNegocio[i].Descripcion;
                    lblEstatus.Text = unidadesDeNegocio[i].Estatus.ToString();
                    lblIdUnidadNegocio.Text = unidadesDeNegocio[i].IdUnidadNegocio.ToString();
                    lblPrestamos.Text = unidadesDeNegocio[i].Prestamos.ToString();
                    lblUrlImagen.Text = unidadesDeNegocio[i].UrlImagen;
                    lblZona.Text = unidadesDeNegocio[i].Zona;
                }
            }

        }

        private void cmbUnidadesNegocioNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionaDatosUnidadNegocio();
        }
    }
}
