using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace soMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult MyAction()
        {
            var model = new List<MyModel>();
            for (int i = 0; i < 10; i++)
            {
                var item = new MyModel() 
                    {
                    Name = string.Format("Name{0}", i),
                    Use = (i % 2 == 0),
                    ListAId = null,
                    ListBId = null,
                    ListCId = null
                    };

                for (int j = 0; j < 10; j++)
			    {
			        item.ListA.Add( new ListAList() 
                        {
                            Id=j,
                            Name = string.Format("Name {0}-{1}",i,j)
                        });
			    }
                model.Add(item);
            }

            return View(model);
        }

        public JsonResult PopulateOption(int? listid, string name)
        {

            //todo: preparing the data source filter

            var sites = new[]
            {
                new { id = "1", name = "Name 1" },
                new { id = "2", name = "Name 2" },
                new { id = "3", name = "Name 3" },
            };
            return Json(sites, JsonRequestBehavior.AllowGet);
        }
    }
}
