using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TurnadorClient.Model
{
    [DataContract]
    public class TurnoAtendiendo 
    {
        [DataMember]
        public int Key { get; set; }

        [DataMember]
        public Turno[] Value { get; set; }

        public TurnoAtendiendo()
        {
            Value = new Turno[Key];
        }

    }
}
