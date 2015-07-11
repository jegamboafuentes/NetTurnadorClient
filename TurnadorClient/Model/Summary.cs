using System;
using System.Runtime.Serialization;

namespace TurnadorClient.Model

{
    [DataContract]
    public class Summary
    {
        [DataMember]
        public bool Complete { get; set; }
        [DataMember]
        public string Detail { get; set; }
        [DataMember]
        public int Status { get; set; }
    }
}
