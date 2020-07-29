using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraineeMVC.Models;

namespace TraineeMVC.Controllers
{
    public class TraineeController : Controller
    {

        public static List<TraineeModel> traineeList= new List<TraineeModel>();
        // GET: Trainee
        [OutputCache(Duration = 20)]
        public ActionResult AddTrainee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTrainee(FormCollection model)
        {
            TraineeModel trainee = new TraineeModel {
                TraineeId = Convert.ToInt32(model["TraineeId"]),
                Name=model["Name"],
                Email = model["Email"],
                DateOfJoining=Convert.ToDateTime(model["DateOfJoining"])
            };
            traineeList.Add(trainee);
            return View("ListTrainee");
        }

        public ActionResult ListTrainee()
        {
            return View(traineeList);
        }
    }
}