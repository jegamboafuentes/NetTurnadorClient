using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurnadorClient.Vistas
{
    public partial class Display : Form
    {

        public Display()
        {
            InitializeComponent();
            Navigate(Principal.SERVIDOR);
        }

        private void Navigate(string servidor)
        {
            string ouput;
            try
            {
                int startIndex = servidor.IndexOf("/") + 2;
                int length = servidor.IndexOf("/BazCajaFront/Servicios/Turnador/", startIndex) - startIndex;
                ouput = servidor.Substring(startIndex, length).Trim();
                webBrowser1.Navigate("http://" + ouput + "/bazcajafront/display/default.aspx");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el display");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Body.Style = "zoom:90%;";
        }
        

    }
}
