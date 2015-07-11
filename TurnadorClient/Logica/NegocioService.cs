using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

using TurnadorClient.Model;
using TurnadorClient.Vistas;

namespace TurnadorClient.Logica
{
    class NegocioService
    {
        WebClient client = new WebClient();
        Negocio oNegocio = new Negocio();
        int i;

        public Negocio[] GetUnidadesNegocio()
        {
            string servidor =Principal.SERVIDOR;
            string uri = servidor+"CjCRNegocioService.svc/negocio/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string json = reader.ReadToEnd();
                    Negocio[] deserializedUnidadnegocio = JsonConvert.DeserializeObject<Negocio[]>(json);
                    return deserializedUnidadnegocio;
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                MessageBox.Show(ex.Message, "Error al obtener unidades de negocio");
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                }
                throw;
            }

        }

        public int[] GetUnidadesNegocioId()
        {
            int[] unidadesNegocioId = new int[GetUnidadesNegocio().Length];
            for (i = 0; i < GetUnidadesNegocio().Length; i++) 
            {
                oNegocio = GetUnidadesNegocio()[i];
                unidadesNegocioId[i] = oNegocio.IdUnidadNegocio;
            }
            return unidadesNegocioId;
        }

        public string[] GetUnidadesNegocioDescripcion()
        {
            string[] unidadesNegocioDescripcion = new string[GetUnidadesNegocio().Length];
            for (i = 0; i < GetUnidadesNegocio().Length; i++)
            {
                oNegocio = GetUnidadesNegocio()[i];
                unidadesNegocioDescripcion[i] = oNegocio.Descripcion;
            }
            return unidadesNegocioDescripcion;
        }
    }
}
 