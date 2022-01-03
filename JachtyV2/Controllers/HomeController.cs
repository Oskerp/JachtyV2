using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace JachtyV2.Controllers
{
    public class HomeController : Controller
    {

       /* SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        */

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult JM()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /*private void FetchData() {
            try
            {
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }*/

        public ActionResult JSL()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}