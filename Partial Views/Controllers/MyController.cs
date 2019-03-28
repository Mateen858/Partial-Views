using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Partial_Views.Controllers
{
    public class MyController : Controller
    {
        // GET: 
        Test test = new Test
        {
            SrNo = 1,
            Name = "Rana Abdul Mateen",
            Designation = "Full Stack Developer"
        };
        List<Test> testList = new List<Test>
        {
            new Test{
            SrNo = 1,
            Name = "Rana Abdul Mateen",
            Designation = "Full Stack Developer"
        },

            new Test{
            SrNo = 2,
            Name = "Ali",
            Designation = "Mobile App Developer"
        },

            new Test{
            SrNo = 3,
            Name = "Ahmed",
            Designation = "Software Developer"
        },
        };

        public ActionResult Index()
        {
            ViewBag.abcList = testList;
            return View();
        }
    }
}