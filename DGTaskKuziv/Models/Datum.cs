using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DGTaskKuziv.Models
{
    public class Datum
    {
        [System.Xml.Serialization.XmlElement("value")]
        public double Value { get; set; }
        [System.Xml.Serialization.XmlElement("taskname")]
        public string TaskName { get; set; }
        [System.Xml.Serialization.XmlElement("animalid")]
        public string AnimalId { get; set; }
        [System.Xml.Serialization.XmlElement("status")]
        public string Status { get; set; }
        [System.Xml.Serialization.XmlElement("inputway")]
        public string InputWay { get; set; }
        [System.Xml.Serialization.XmlElement("userinfo")]
        public string UserInfo { get; set; }
        [System.Xml.Serialization.XmlElement("mortalityanotation")]
        public string MortalityaNotation { get; set; }
        [System.Xml.Serialization.XmlElement("taskid")]
        public string TaskId { get; set; }
        [System.Xml.Serialization.XmlElement("studyday")]
        public int Studyday { get; set; }
        [System.Xml.Serialization.XmlElement("iscensored")]
        public string Iscensored { get; set; }
        [XmlArray("customvalues")]
        [XmlArrayItem("customvalue", typeof(CustomValue))]
        public CustomValue[] CustomValues { get; set; }
    }
}