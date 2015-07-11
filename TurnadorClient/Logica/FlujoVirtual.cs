using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using TurnadorClient.Logica;
using TurnadorClient.Model;
using TurnadorClient.Util;

namespace TurnadorClient.Logica
{
    class FlujoVirtual
    {
        TurnosService oLogicTurnosService = new TurnosService();
        PoolService oLogicPoolService = new PoolService();
        Utilidades Util = new Utilidades();


        public void flujoTurnoVirtual(string empleado,int TiempoMin, int TiempoMax)
        {
            string unidadNegocio = oLogicPoolService.ConsultaUnidadNegocio(empleado).IdUnidadNegocio.ToString();
            string fecha = Util.getFecha();

            Turno oTurno = new Turno();

            Random random = new Random();
            int randomTiempos = 0;
            int tiempoMinConvert = TiempoMin * 1000;
            int tiempoMaxConvert = TiempoMax * 1000;
            /*Se consulta si el empleado tiene asignado un turno, si lo tiene 
             * este turno lo pospone y genera un turno virtual
             */
            randomTiempos = random.Next(tiempoMinConvert, tiempoMaxConvert);
            oTurno = oLogicTurnosService.ObtenerTurnoAsignado(fecha, unidadNegocio, empleado);
            if (oTurno.IdTurno == 0) //Si no tiene turno asignado
            {
                oLogicTurnosService.AtiendeTurnoVirtual(empleado, unidadNegocio, 1);
                oTurno = oLogicTurnosService.ObtenerTurnoAtendiendo(fecha, empleado);
                string idTurno = oTurno.IdTurno.ToString();
                Thread.Sleep(randomTiempos);
                oLogicTurnosService.FinalizarTurno(empleado, fecha, idTurno, unidadNegocio, 1);
            }
            else
            {
                string idTurno = oTurno.IdTurno.ToString();
                oLogicTurnosService.PosponerTurno(fecha, idTurno, unidadNegocio, 1);
                oLogicTurnosService.AtiendeTurnoVirtual(empleado, unidadNegocio, 1);
                oTurno = oLogicTurnosService.ObtenerTurnoAtendiendo(fecha, empleado);
                idTurno = oTurno.IdTurno.ToString();
                Thread.Sleep(randomTiempos);
                oLogicTurnosService.FinalizarTurno(empleado, fecha, idTurno, unidadNegocio, 1);
                oLogicPoolService.SetDisponible(empleado, 1);

            }

        }



    }
}
