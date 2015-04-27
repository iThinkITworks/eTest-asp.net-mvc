using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace etest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(Session["LoggedUserID"] != null){
                return View();
            } else {
                return RedirectToAction("Login");
            }
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            if (Session["LoggedUserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            if (Session["LoggedUserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(user u)
        {
            if(ModelState.IsValid){
                using (ge_test_schemaEntities ge = new ge_test_schemaEntities())
                {
                    var v = ge.users.Where(a => a.LoginName.Equals(u.LoginName) &&
                        a.Password.Equals(u.Password)).FirstOrDefault();
                    if(v != null){
                        Session["LoggedUserID"] = v.UserID.ToString();
                        Session["LoggedUsername"] = v.LoginName.ToString();
                        return RedirectToAction("Index");
                    }
                }
            }
            return View();
        }

        //public ActionResult Main()
        //{
        //    if(Session["LoggedUserID"] != null){
        //        return View();
        //    } else {
        //        return RedirectToAction("Login");
        //    }
        //}

        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("Login");
        }
    }
}