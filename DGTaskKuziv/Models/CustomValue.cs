using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DGTaskKuziv.Models
{
    public class CustomValue
    {
        [System.Xml.Serialization.XmlElement("name")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("value")]
        public double Value { get; set; }
    }
}