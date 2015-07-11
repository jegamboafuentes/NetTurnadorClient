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
    class PoolService
    {
        Summary oSummary = new Summary();
        WebClient client = new WebClient();
        Principal oPrincipal = new Principal();

        public Summary SetNoDisponible(String noEmpleado,int pantallas)
        {
            string servidor = Principal.SERVIDOR;
            string uri = servidor + "CjCRPoolService.svc/pool/"+noEmpleado+"/nodisponible/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "PUT";
            request.Headers.Add("Authorization", "{dt:true}");
            System.Text.UTF8Encoding encording = new System.Text.UTF8Encoding();
            string body = "";
            Byte[] byteArray = encording.GetBytes(body);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            long lenght = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    lenght = response.ContentLength;
                    //----
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    try
                    {
                        JObject jsonFormated = JObject.Parse(json);
                        Summary deserializedTurno = JsonConvert.DeserializeObject<Summary>(json);
                        if (pantallas == 0)
                        MessageBox.Show(jsonFormated.ToString(), "Empleado no disponible");
                        oSummary = deserializedTurno;
                        return oSummary;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(json, "Error");
                        oSummary.Complete = false;
                        return oSummary;
                    }
                }

            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Error");
                oSummary.Complete = false;
                return oSummary;
            }


        }
        public Summary SetDisponible(String noEmpleado, int pantallas)
        {
            string servidor = Principal.SERVIDOR;
            string uri = servidor + "CjCRPoolService.svc/pool/" + noEmpleado + "/disponible/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "PUT";
            request.Headers.Add("Authorization", "{dt:true}");
            System.Text.UTF8Encoding encording = new System.Text.UTF8Encoding();
            string body = "";
            Byte[] byteArray = encording.GetBytes(body);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            long lenght = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    lenght = response.ContentLength;
                    //----
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    try
                    {
                        JObject jsonFormated = JObject.Parse(json);
                        Summary deserializedTurno = JsonConvert.DeserializeObject<Summary>(json);
                        if (pantallas == 0)
                        MessageBox.Show(jsonFormated.ToString(), "Empleado disponible");
                        oSummary = deserializedTurno;
                        return oSummary;
                    }
                    catch (Exception )
                    {
                        MessageBox.Show(json, "Error");
                        oSummary.Complete = false;
                        return oSummary;
                    }
                }

            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Error");
                oSummary.Complete = false;
                return oSummary;
            }


        }
        public void SetPuntoAtencion(String noEmpleado, String puntoAtencion, int pantallas)
        {
            string servidor = Principal.SERVIDOR;
            string uri = servidor + "CjCRPoolService.svc/pool/" + noEmpleado + "/puntoatencion/"+puntoAtencion+"/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "PUT";
            request.Headers.Add("Authorization", "{dt:true}");
            System.Text.UTF8Encoding encording = new System.Text.UTF8Encoding();
            string body = "";
            Byte[] byteArray = encording.GetBytes(body);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            long lenght = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    lenght = response.ContentLength;
                    //----
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    try
                    {
                        JObject jsonFormated = JObject.Parse(json);
                        if (pantallas == 0)
                        MessageBox.Show(jsonFormated.ToString(), "Registra punto atencion");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(json, "Error");
                    }
                }

            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public Empleado ConsultaUnidadNegocio(String noEmpleado)
        {
            string servidor = Principal.SERVIDOR;
            string uri = servidor + "CjCRPoolService.svc/pool/"+noEmpleado+"/unidad/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Headers.Add("Authorization", "{dt:true}");
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    Empleado deserializedUnidadnegocioEmpleado = JsonConvert.DeserializeObject<Empleado>(json);
                    return deserializedUnidadnegocioEmpleado;
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                MessageBox.Show(ex.Message, "Error al obtener la unidad de negocio del empleado "+noEmpleado);
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                }
                throw;
            }
        }
    }
}
