using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


using TurnadorClient.Model;
using TurnadorClient.Vistas;


namespace TurnadorClient.Logica
{
    class TurnosService
    {
        Summary oSummary = new Summary();
        WebClient client = new WebClient();
        Principal oPrincipal = new Principal();
        

        string statusHTTP; 

        public Summary GeneraTurno(string origen, string unidadNegocio, string turnoSeguimiento, int pantallas)
        {
            string servidor = Principal.SERVIDOR;
            string uri = servidor+"CjCRTurnosService.svc/turno/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "POST";
            request.Headers.Add("Authorization","{dt:true}");
            System.Text.UTF8Encoding encording = new System.Text.UTF8Encoding();
            string body = "{\"IdOrigen\":" + origen+ ", \"IdUnidadNegocio\":" + unidadNegocio + ", \"IdTurnoSeguimiento\":" + turnoSeguimiento+"}";
            Byte[] byteArray = encording.GetBytes(body);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            long lenght = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    lenght = response.ContentLength;
                    statusHTTP = response.StatusCode.ToString();
                    //----
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    JObject jsonFormated = JObject.Parse(json);
                    if(pantallas == 0)
                    MessageBox.Show(jsonFormated.ToString(),"Turno generado");
                    oSummary.Complete = true;
                    return oSummary;
                }

                    
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Error");
                oSummary.Complete = false;
                return oSummary;
            }
        }

        public Summary AtenderTurno(string noEmpleado, string fecha, string idTurno, string idUnidadNegocio, int pantallas)
        {
            string servidor = Principal.SERVIDOR;
            string uri = servidor + "CjCRTurnosService.svc/turno/"+noEmpleado+"/atender/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "PUT";
            request.Headers.Add("Authorization","{dt:true}");
            System.Text.UTF8Encoding encording = new System.Text.UTF8Encoding();
            string body = "{\"Fecha\":" + fecha+ ", \"IdTurno\":" + idTurno + ", \"IdUnidadNegocio\":" + idUnidadNegocio+"}";
            Byte[] byteArray = encording.GetBytes(body);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            long lenght = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    lenght = response.ContentLength;
                    statusHTTP = response.StatusCode.ToString();
                    //----
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    try
                    {
                        JObject jsonFormated = JObject.Parse(json);
                        if (pantallas == 0)
                        MessageBox.Show(jsonFormated.ToString(), "Turno Atendido");
                        oSummary.Complete = true;
                        return oSummary;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(json, "Error");
                        oSummary.Complete = false;
                        return oSummary;
                    }
                }
                //oSummaryForm.
                    
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Error");
                oSummary.Complete = false;
                return oSummary;
            }
        }

        public Summary FinalizarTurno(string noEmpleado, string fecha, string idTurno, string idUnidadNegocio, int pantallas)
        {
            string servidor = Principal.SERVIDOR;
            string uri = servidor + "CjCRTurnosService.svc/turno/" + noEmpleado + "/finalizar/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "PUT";
            request.Headers.Add("Authorization", "{dt:true}");
            System.Text.UTF8Encoding encording = new System.Text.UTF8Encoding();
            string body = "{\"Fecha\":" + fecha + ", \"IdTurno\":" + idTurno + ", \"IdUnidadNegocio\":" + idUnidadNegocio + "}";
            Byte[] byteArray = encording.GetBytes(body);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            long lenght = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    lenght = response.ContentLength;
                    statusHTTP = response.StatusCode.ToString();
                    //----
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    try
                    {
                        JObject jsonFormated = JObject.Parse(json);
                        if (pantallas == 0)
                        MessageBox.Show(jsonFormated.ToString(), "Turno Finalizado");
                        oSummary.Complete = true;
                        return oSummary;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(json, "Error");
                        oSummary.Complete = false;
                        return oSummary;
                    }
                }
                //oSummaryForm.

            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Error");
                oSummary.Complete = false;
                return oSummary;
            }
        }

        public Turno ObtenerTurnoAsignado(string fecha, string idUnidadNegocio, string noEmpleado)
        {
            string servidor = Principal.SERVIDOR;
            string uri = servidor + "CjCRTurnosService.svc/turno/"+fecha+"/"+idUnidadNegocio+"/"+noEmpleado+"/asignado/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    Turno deserializedTurno = JsonConvert.DeserializeObject<Turno>(json);
                    return deserializedTurno;
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                MessageBox.Show(ex.Message, "Error al obtener el turno asignado al empleado "+noEmpleado);
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                }
                throw;
            }

        }

        public TurnoAtendiendo[] ObtenerTurnosAtendiendo(string fecha)
        {
            string servidor = Principal.SERVIDOR;
            string uri = servidor + "CjCRTurnosService.svc/turno/" + fecha + "/negocio/atendiendo/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    TurnoAtendiendo[] deserializedTurno = JsonConvert.DeserializeObject<TurnoAtendiendo[]>(json);
                    return deserializedTurno;
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                MessageBox.Show(ex.Message, "Error al obtener los turnos atendiendo");
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                }
                throw;
            }

        }

        public Turno ObtenerTurnoAtendiendo(string fecha, string noEmpleado)
        {
            int tamanoArregloUnidadesNegocio = ObtenerTurnosAtendiendo(fecha).Length;
            TurnoAtendiendo[] turnosAtendiendo = new TurnoAtendiendo[tamanoArregloUnidadesNegocio];
            Turno turnoAtendiendo = new Turno();
            turnosAtendiendo = ObtenerTurnosAtendiendo(fecha);
            for (int i = 0; i < tamanoArregloUnidadesNegocio; i++)
            {
                for (int j = 0; j < turnosAtendiendo[i].Value.Length; j++)
                {
                    if (turnosAtendiendo[i].Value[j].Empleado.NoEmpleado == noEmpleado)
                    {
                        turnoAtendiendo = turnosAtendiendo[i].Value[j];
                    }
                }
            }
            return turnoAtendiendo;
        }

        public Summary PosponerTurno(string fecha, string idTurno, string idUnidadNegocio, int pantallas)
        {
            string servidor = Principal.SERVIDOR;
            string uri = servidor + "CjCRTurnosService.svc/turno/posponer/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "PUT";
            request.Headers.Add("Authorization", "{dt:true}");
            System.Text.UTF8Encoding encording = new System.Text.UTF8Encoding();
            string body = "{\"Fecha\":" + fecha + ", \"IdTurno\":" + idTurno + ", \"IdUnidadNegocio\":" + idUnidadNegocio + "}";
            Byte[] byteArray = encording.GetBytes(body);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            long lenght = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    lenght = response.ContentLength;
                    statusHTTP = response.StatusCode.ToString();
                    //----
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    try
                    {
                        JObject jsonFormated = JObject.Parse(json);
                        if (pantallas == 0)
                            MessageBox.Show(jsonFormated.ToString(), "Turno Pospuesto");
                        oSummary.Complete = true;
                        return oSummary;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(json, "Error");
                        oSummary.Complete = false;
                        return oSummary;
                    }
                }
                //oSummaryForm.

            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Error");
                oSummary.Complete = false;
                return oSummary;
            }
        }

        public Summary AtiendeTurnoVirtual(string noEmpleado, string unidadNegocio, int pantallas)
        {
            string servidor = Principal.SERVIDOR;
            string uri = servidor + "CjCRTurnosService.svc/turno/virtual/" + unidadNegocio + "/" + noEmpleado + "/atender/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "POST";
            request.Headers.Add("Authorization", "{dt:true}");
            System.Text.UTF8Encoding encording = new System.Text.UTF8Encoding();
            string body = "";
            Byte[] byteArray = encording.GetBytes(body);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            long lenght = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    lenght = response.ContentLength;
                    statusHTTP = response.StatusCode.ToString();
                    //----
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    JObject jsonFormated = JObject.Parse(json);
                    if (pantallas == 0)
                        MessageBox.Show(jsonFormated.ToString(), "Turno Virtual generado");
                    oSummary.Complete = true;
                    return oSummary;
                }


            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Error");
                oSummary.Complete = false;
                return oSummary;
            }
        }
    }

}
