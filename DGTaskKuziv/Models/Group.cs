using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DGTaskKuziv.Models
{
    public class Group
    {
        [System.Xml.Serialization.XmlElement("name")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("id")]
        public Guid Id { get; set; }
        [System.Xml.Serialization.XmlElement("requestedmales")]
        public int Requestedmales { get; set; }
        [System.Xml.Serialization.XmlElement("requestedfemales")]
        public int RequestedFemales { get; set; }
        [System.Xml.Serialization.XmlElement("males")]
        public int Males { get; set; }
        [System.Xml.Serialization.XmlElement("females")]
        public int Females { get; set; }
        [System.Xml.Serialization.XmlElement("articlescount")]
        public int Articlescount { get; set; }
        [System.Xml.Serialization.XmlElement("diseasecount")]
        public int Diseasecount { get; set; }
        [XmlArray("sessions")]
        [XmlArrayItem("session", typeof(Session))]
        public Session[] Sessions { get; set; }
    }
}