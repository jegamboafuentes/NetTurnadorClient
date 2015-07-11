using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using TurnadorClient;
using TurnadorClient.Model;
using TurnadorClient.Logica;
using TurnadorClient.Util;
using TurnadorClient.Vistas;
using TurnadorClient.Vistas.HappyPath;

namespace TurnadorClient.Logica
{
    public class HappyPath
    {

        Utilidades oUtil = new Utilidades();

        TurnosService oTurnosService = new TurnosService();
        PoolService oPoolService = new PoolService();
        Turno oTurno = new Turno();

        public int cantidadDeTurnos;
        public int turnosTotalValue;
        public string idTurnoFlow;
        public string tiempoEspera;

        public void HappySencillo(string empleado, string unidadNegocio, string cantidadTurnos,int tiempoMinimo, int tiempoMaximo)
        {
            TurnadorClient.Vistas.HappyPath.HappySencillo oBarra = new Vistas.HappyPath.HappySencillo();
            Random random = new Random();

            bool setDisponible;
            bool generaTurno;
            bool atiendeTurno;
            bool finalizaTurno;

            string error = null ;

            cantidadDeTurnos = Int32.Parse(cantidadTurnos);
            int randomTiempos = 0;
            int tiempoMinConvert = tiempoMinimo * 1000;
            int tiempoMaxConvert = tiempoMaximo * 1000;
            

            string fecha = oUtil.getFecha();
            //Todo lo que se haga ira dentro de un for que repetira el numero de veces que se desea obtener el turno
            for (int i = 0; i < cantidadDeTurnos; i++)
            {
                randomTiempos = random.Next(tiempoMinConvert, tiempoMaxConvert);
                tiempoEspera = (randomTiempos / 1000).ToString() + "." + (randomTiempos % 1000)+" seg."; 
                try
                {
                    setDisponible = oPoolService.SetDisponible(empleado, 1).Complete;
                    if (setDisponible == true)
                    {
                        generaTurno = oTurnosService.GeneraTurno("1", unidadNegocio, "0", 1).Complete;
                        if (generaTurno == true)
                        {
                            oTurno = oTurnosService.ObtenerTurnoAsignado(fecha, unidadNegocio, empleado);
                            string noEmpleadoAtiende = oTurno.Empleado.NoEmpleado;
                            string fechaAtiende = oTurno.Fecha.ToString();
                            string idTurnoAtiende = oTurno.IdTurno.ToString();
                            string idUnidadNegocioAtiende = oTurno.IdUnidadNegocio.ToString();
                            atiendeTurno = oTurnosService.AtenderTurno(noEmpleadoAtiende, fechaAtiende, idTurnoAtiende, idUnidadNegocioAtiende, 1).Complete;
                            idTurnoFlow = idTurnoAtiende;
                            Thread.Sleep(randomTiempos);
                            //MessageBox.Show("Tiempo en atender turno:" + randomTiempos/1000);
                            if (atiendeTurno == true)
                            {
                                oTurno = oTurnosService.ObtenerTurnoAtendiendo(fecha, empleado);
                                string noEmpleadoFinaliza = oTurno.Empleado.NoEmpleado;
                                string fechaFinaliza = oTurno.Fecha.ToString();
                                string idTurnoFinaliza = oTurno.IdTurno.ToString();
                                string idUnidadNegocioFinaliza = oTurno.IdUnidadNegocio.ToString();
                                finalizaTurno = oTurnosService.FinalizarTurno(noEmpleadoFinaliza, fechaFinaliza, idTurnoFinaliza, idUnidadNegocioFinaliza, 1).Complete;
                                if (finalizaTurno == true)
                                {
                                    turnosTotalValue = i + 1;
                                }
                                else
                                {
                                    error = "Error al finalizar el turno";
                                    break;
                                }
                            }
                            else
                            {
                                error = "Error al atender el turno";
                                break;
                            }
                        }
                        else
                        {
                            error = "Error al generar turno";
                            break;
                        }
                    }
                    else
                    {
                        error = "Error al poner disponible al empleado";
                        break;
                    }

                }
                catch (Exception exHappy)
                {
                    string exepcion = exHappy.GetType().ToString();
                    if (exepcion == "System.Threading.ThreadAbortException")
                    {
                        MessageBox.Show("Happy Path cancelado", "Cancelado");
                    }
                    else
                    {
                        MessageBox.Show("Error en Happy Path:" + exHappy.Data, "Error");
                        break;
                    }
                }
            }
            if (error != null)
            {
                MessageBox.Show(error, "Error");
            }
            else
            {
                MessageBox.Show("Se completo el flujo " + turnosTotalValue + " veces exitosamente", "Happy path completo");
            }
        }

    }
}
