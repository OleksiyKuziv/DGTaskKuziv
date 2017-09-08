using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DGTaskKuziv.Models
{
    public class Session
    {
        [System.Xml.Serialization.XmlElement("sessiondate")]
        public string SessionDate { get; set; }
        [System.Xml.Serialization.XmlElement("sessionnote")]
        public string SessionNote { get; set; }
        [System.Xml.Serialization.XmlElement("sessionday")]
        public string SessionDay { get; set; }
        [XmlArray("animals")]
        [XmlArrayItem("animal", typeof(Animal))]
        public Animal[] Animals { get; set; }        
    }
}