using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DGTaskKuziv.Models
{
    public class Animal
    {
        [System.Xml.Serialization.XmlElement("id")]
        public Guid Id { get; set; }
        [System.Xml.Serialization.XmlElement("studyanimalid")]
        public string StudyAnimalId { get; set; }
        [System.Xml.Serialization.XmlElement("groupid")]
        public string GroupId { get; set; }
        [System.Xml.Serialization.XmlElement("group_x0020_name")]
        public string Group_x0020_Name { get; set; }
        [System.Xml.Serialization.XmlElement("animalorderid")]
        public Guid AnimalOrderId { get; set; }
        [System.Xml.Serialization.XmlElement("animalordername")]
        public string AnimalOrderName { get; set; }
        [System.Xml.Serialization.XmlElement("fatedate")]
        public string FateDate { get; set; }
        [System.Xml.Serialization.XmlElement("fatecode")]
        public string FateCode { get; set; }
        [System.Xml.Serialization.XmlElement("fatedescription")]
        public string FateDescription { get; set; }
        [System.Xml.Serialization.XmlElement("iscensored")]
        public string Iscensored { get; set; }
        [System.Xml.Serialization.XmlElement("sex")]
        public string Sex { get; set; }
        [System.Xml.Serialization.XmlElement("temp_x0020_id")]
        public string Temp_x0020_Id { get; set; }
        [System.Xml.Serialization.XmlElement("animal_x0020_id")]
        public string Animal_x0020_Id { get; set; }
        [System.Xml.Serialization.XmlElement("date_x0020_of_x0020_birth")]
        public string Date_x0020_Of_x0020_Birth { get; set; }
        [System.Xml.Serialization.XmlElement("mortality_x0020_code")]
        public string Mortality_x0020_Code { get; set; }
        [System.Xml.Serialization.XmlElement("mortality_x0020_classification_x0020_abbr")]
        public string Mortality_x0020_Classification_x0020_Abbr { get; set; }
        [System.Xml.Serialization.XmlElement("mortality_x0020_description")]
        public string Mortality_x0020_Description { get; set; }
        [System.Xml.Serialization.XmlElement("mortality_x0020_date")]
        public string Mortality_x0020_Date { get; set; }
        [System.Xml.Serialization.XmlElement("staging_x0020_date")]
        public string Staging_x0020_Date { get; set; }
        [System.Xml.Serialization.XmlElement("mortality_x0020_classification")]
        public int Mortality_x0020_Classification { get; set; }
        [XmlArray("data")]
        [XmlArrayItem("datum", typeof(Datum))]
        public Datum[] Data { get; set; }      
    }
}