using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TurnadorClient.Vistas;

namespace TurnadorClient.Util
{
    public class Utilidades
    {
        Configuracion config = new Configuracion();

        public bool configuracion()
        {
            if (Principal.SERVIDOR == null)
            {
                MessageBox.Show("No has configurado el servidor", "Error");
                config.Show();
                return false;
            }
            else
            {
                return true;
            }
        }

        public string getFecha()
        {
            string fecha;
            string ano = DateTime.Now.Year.ToString();
            string mes = DateTime.Now.Month.ToString();
            if (mes.Length != 2)
            {
                mes = "0" + mes;
            }

            string dia = DateTime.Now.Day.ToString();
            if (dia.Length != 2)
            {
                dia = "0" + dia;
            }
            fecha = ano + mes + dia;
            return fecha;
        }

    }
}
