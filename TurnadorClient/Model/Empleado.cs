using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace TurnadorClient.Model
{
    [DataContract]
    public class Empleado
    {
        [DataMember]
        public int Estado { get; set; }

        [DataMember]
        public int IdUnidadNegocio { get; set; }

        [DataMember]
        public string NoEmpleado  {get; set;}

        [DataMember]
        public string Nombre { get; set;}

        public string PuntoAtencion { get; set; }

    }
}
