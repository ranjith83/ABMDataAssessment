using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PayloadService
{
    [DataContract]
    public class PayloadContract
    {
        [DataMember]
        public bool ValidXML { get; set; }

        [DataMember]
        public string CommandStatus { get; set; }

        [DataMember]
        public string SiteStatus { get; set; }
    }
}