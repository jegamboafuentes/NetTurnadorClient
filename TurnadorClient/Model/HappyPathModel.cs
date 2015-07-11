using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace TurnadorClient.Model
{
    [DataContract]
    public class HappyPathModel
    {
        [DataMember]
        public Turno Turno { get; set; }

        [DataMember]
        public bool setDisponible { get; set; }

        [DataMember]
        public bool generaTurno { get; set; }

        [DataMember]
        public bool atiendeTurno { get; set; }

        [DataMember]
        public bool finalizaTurno { get; set; }

        public HappyPathModel()
        {
            Turno = new Turno();
        }
    }
}
