using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DGTaskKuziv.Models
{
    [System.Xml.Serialization.XmlRoot("task")]
    public class Task
    {
        [System.Xml.Serialization.XmlElement("name")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("tasktype")]
        public string TaskType { get; set; }
        [System.Xml.Serialization.XmlElement("id")]
        public Guid Id { get; set; }
        [System.Xml.Serialization.XmlElement("articleid")]
        public Guid ArticleId { get; set; }
        [System.Xml.Serialization.XmlElement("diseaseinductionid")]
        public Guid DiseaseinductionId { get; set; }
        [System.Xml.Serialization.XmlElement("abbr")]
        public string Abbr { get; set; }
        [System.Xml.Serialization.XmlElement("unitname")]
        public string UnitName { get; set; }
        [System.Xml.Serialization.XmlElement("datatype")]
        public string DataType { get; set; }
        [System.Xml.Serialization.XmlElement("dose_x0020_volume")]
        public int Dose_x0020_volume { get; set; }
        [System.Xml.Serialization.XmlElement("dose_x0020_rule")]
        public string Dose_x0020_rule { get; set; }
        [System.Xml.Serialization.XmlElement("dose_x0020_volume_x0020_diff")]
        public int Dose_x0020_volume_x0020_diff { get; set; }
        [System.Xml.Serialization.XmlElement("terminateat")]
        public int Terminateat { get; set; }
        [System.Xml.Serialization.XmlElement("treatmentbegins")]
        public int Treatmentbegins { get; set; }
        [System.Xml.Serialization.XmlElement("treatmentbegins2")]
        public int Treatmentbegins2 { get; set; }
        [XmlArray("groups")]
        [XmlArrayItem("group",typeof(Group))]
        public Group[] Groups { get; set; }
    }
}