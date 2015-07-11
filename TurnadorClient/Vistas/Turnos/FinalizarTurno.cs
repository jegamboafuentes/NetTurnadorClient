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
    public partial class FinalizarTurno : Form
    {
        Utilidades oUtilidades = new Utilidades();
        TurnosService oTurnosService = new TurnosService();

        PoolService oPoolService = new PoolService();

        Empleado oEmpleado = new Empleado();
        Turno oTurno = new Turno();
        TurnoAtendiendo oTurnoAtendiendo = new TurnoAtendiendo();

        public FinalizarTurno()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string noEmpleado = txtNoEmpleado.Text;
            string fecha = txtFecha.Text;
            string idTurno = txtIdTurno.Text;
            string idUnidadNegocio = txtIdUnidadNegocio.Text;
            oTurnosService.FinalizarTurno(noEmpleado, fecha, idTurno, idUnidadNegocio,0);
        }

        private void AtenderTurno_Load(object sender, EventArgs e)
        {
            if (oUtilidades.configuracion() == false)
            {
                this.Close();
            }
            else
            {
                txtFecha.Text = oUtilidades.getFecha();
            }          
        }

        private void cmdSmart_Click(object sender, EventArgs e)
        {
            if (txtNoEmpleado.Text.Length != 6)
            {
                MessageBox.Show("El numero de empleado es incorrecto", "Error");
            }
            else
            {
                string noEmpleado = txtNoEmpleado.Text;
                string fecha = txtFecha.Text;
                oEmpleado = oPoolService.ConsultaUnidadNegocio(noEmpleado);
                int idUnidadNegocio = oEmpleado.IdUnidadNegocio;
                txtIdUnidadNegocio.Text = idUnidadNegocio.ToString();
                //oTurnoAtendiendo = oTurnosService.ObtenerTurnosAtendiendo(fecha);
                oTurno = oTurnosService.ObtenerTurnoAtendiendo(fecha, noEmpleado);
                string idTurno = oTurno.IdTurno.ToString();
                if (idTurno == "0") MessageBox.Show("Este empleado no esta atendiendo ningun turno");
                txtIdTurno.Text = idTurno;
            }
        }
    }
}
