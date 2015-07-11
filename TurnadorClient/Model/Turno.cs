﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TurnadorClient.Model
{
    [DataContract]
    public class Turno
    {
        [DataMember]
        public int IdTurno { get; set; }

        [DataMember]
        public int Fecha { get; set; }

        [DataMember]
        public int Estado { get; set; }

        [DataMember]
        public int IdOrigen { get; set; }

        [DataMember]
        public int IdUnidadNegocio { get; set; }

        [DataMember]
        public int TurnoSeguimiento { get; set; }

        [DataMember]
        public int Prioridad { get; set; }

        [DataMember]
        public int Virtual { get; set; }

        [DataMember]
        public Empleado Empleado { get; set; }

        public Turno()
        {
            Empleado = new Empleado();
        }

    }
}
