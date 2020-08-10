using StoreApiPoc.Areas.Helper_Class;
using StoreApiPoc.Models;
using StoreApiPoc.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreApiPoc.Areas.LoginArea.Controllers
{
    public class HomeController : Controller
    {
        // GET: LoginArea/Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginAreaLogin login)
        {
            StoreDBEntities1 entities = new StoreDBEntities1();
            ObjectParameter status = new ObjectParameter("Status", 0);

            ObjectResult<int?> logincode = entities.spCustomerLogin(login.Email, login.Password,status);
            int loginCode = (int)logincode.FirstOrDefault<int?>();
            if (loginCode>0)
            {
                if (loginCode > 1)
                {
                    Session["CustomerEmail"] = login.Email;
                    return View("Shopping");
                }
                ViewBag.CustomerVerification = false;
                ViewBag.Email = login.Email;
                Random r = new Random();
                Session["OTP"] = r.Next(1111, 9999);
                //change email parameter after testing 
                bool emailSent = EmailVerification.SendEmailOTP(Convert.ToInt32(Session["OTP"]), "abhishekbajpai449@gmail.com",login.Email);
                return View("Verification");
            }
            ViewBag.CustomerCredentials = false;
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(CustomerRegistrationEntity customerRegistrationEntity)
        {
            StoreDBEntities1 entities = new StoreDBEntities1();
            try
            {
                entities.spCustomerRegistration(
                    customerRegistrationEntity.Email,
                    customerRegistrationEntity.FName,
                    customerRegistrationEntity.LName,
                    customerRegistrationEntity.Address,
                    customerRegistrationEntity.Password
                    );
                entities.SaveChanges();
                ViewBag.Email = customerRegistrationEntity.Email;
                Random r = new Random();
                Session["OTP"] = r.Next(1111, 9999);
                //change email parameter after testing 
                bool emailSent=EmailVerification.SendEmailOTP(Convert.ToInt32(Session["OTP"]), "abhishekbajpai449@gmail.com", customerRegistrationEntity.FName);
                if (emailSent)
                    return View("Verification");
                return View("Registration");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return View("Registration");
        }

        [HttpGet]
        public ActionResult Verification()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verification(CustomerVerification customerVerification)
        {
            if (customerVerification.OTP == Convert.ToInt32(Session["OTP"])) {
                ViewBag.Signup = true;
                StoreDBEntities1 entities = new StoreDBEntities1();
                int rowsAffected=entities.spActivateCustomer(customerVerification.Email);
                entities.SaveChanges();
                if(rowsAffected>0)
                    return View("Index");
            }
            return View("Verification");
        }

    }
}