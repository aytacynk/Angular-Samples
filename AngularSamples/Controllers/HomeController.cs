using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularSamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetSampleData(int count)
        {
            List<object> list = new List<object>();

            for (int i = 0; i < count; i++)
            {
                list.Add(
                    new
                    {
                        Name = FakeData.NameData.GetFirstName(),
                        Surname = FakeData.NameData.GetSurname(),
                        Age = FakeData.NumberData.GetNumber(10, 100)
                    });
            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}