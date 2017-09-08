using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using DGTaskKuziv.ViewModel;
using System.Globalization;
using DGTaskKuziv.Models;
using System.Xml.Serialization;
using System.IO;

namespace DGTaskKuziv.Controllers
{
    public class HomeController : Controller
    {
        public static List<AnimalViewModel> modelList = new List<AnimalViewModel>();
        public static List<AverageViewModel> modelAverageList = new List<AverageViewModel>();
        public  ActionResult Index()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Task));
            string path = "http://91.232.241.66:92/api/v1/study/89b4effb-40f8-44d9-ba25-c9cbe7602a95/measurements/tasks/3ba2733b-6274-4bee-93ac-6af4eab90e72/?authorization=Basic%20dGVzdF92YWNhbnRpb246dGVzdF92YWNhbnRpb24=";
            XmlTextReader reader = new XmlTextReader(path);
            var task = serializer.Deserialize(reader) as Task;
            if (task != null)
            {
                for (int i = 0; i < task.Groups.Length; i++)
                {
                    for (int j = 0; j < task.Groups[i].Sessions.Length; j++)
                    {
                        AverageViewModel model = new AverageViewModel();
                        model.GroupName = task.Groups[i].Name;
                        model.CurrentDate = task.Groups[i].Sessions[j].SessionDate;
                        double sum = 0;
                        int count;
                        for (count =0; count < task.Groups[i].Sessions[j].Animals.Length; count++)
                        {
                            for (int z = 0; z < task.Groups[i].Sessions[j].Animals[count].Data.Length; z++)
                            {
                                sum += task.Groups[i].Sessions[j].Animals[count].Data[z].Value;
                            }
                        }
                        model.Average = sum / count;
                        model.Id = Guid.NewGuid();
                        modelAverageList.Add(model);                       
                    }
                 }

            }
            return View(modelAverageList);
           
        }
        public JsonResult Data()
        {
            return Json(modelAverageList, JsonRequestBehavior.AllowGet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
            
        }
    }
}