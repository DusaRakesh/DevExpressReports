using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DevExpress.XtraReports.Web.Native.Constants;

namespace McbitssDevReports.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()

        {

            //var id = RouteData.Values["id"] + Request.Url.Query;
           // string url = "http://mcbitsstech.dyndns.biz:8099/?post=linkparameter&comp=5a8451f24d019f2bfc37917f&emp=5abb5ccba6a86d39184073d4&year=2018&month=March&country=India&role=Emp";
            //ViewBag.Role = id;
            string url = this.Request.Url.AbsoluteUri;
            NameValueCollection dtQueryString = GetQueryParameters(url);
            ViewBag.comp = dtQueryString["comp"];
            string comp = ViewBag.comp;

            ViewBag.Country = dtQueryString["country"];
            string country = ViewBag.country;

             ViewBag.emp = dtQueryString["emp"];
            string emp = ViewBag.emp;

            ViewBag.year = dtQueryString["year"];
            string year = ViewBag.year;

            ViewBag.month = dtQueryString["month"];
            string month = ViewBag.month;

            ViewBag.Role = dtQueryString["role"];
            string role = ViewBag.role;

            MethodCall obj = new MethodCall();
            obj.userData(country,role,year,month,emp);


            return View();
        }
        private NameValueCollection GetQueryParameters(string dataWithQuery)
        {
            return HttpUtility.ParseQueryString(dataWithQuery);
        }
    }
}