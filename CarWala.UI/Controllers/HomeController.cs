using CarWala.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CarWala.UI.Controllers
{
    public class HomeController : Controller
    {
        private string amitNumber = "9743192324";
        private string deepakJioNumber = "7021060298";


        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SubmitCabRequest(RequestForm f)
        {
            string smsBody = f.FirstName + " " + f.LastName + " has request a cab at" + f.JourneyTime + " for date " + f.JourneyDate;
            smsBody += ". Pickup loacation: " + f.PickUpLocation;
            smsBody += ". Destination: " + f.Destination;
            smsBody += ". Contact: " + f.Contact;
            var restult = SendSMS("CI00194622", "deepak.nettiwari@gmail.com", "VtwuV4b5", deepakJioNumber, smsBody);
            return Json('1');
            //return Json('0');
        }

        private int SendSMS(String AccountID, String Email, String Password, String Recipient, String Message)
        {
            WebClient Client = new WebClient();
            String RequestURL, RequestData;

            RequestURL = "https://redoxygen.net/sms.dll?Action=SendSMS";

            RequestData = "AccountId=" + AccountID
                + "&Email=" + System.Web.HttpUtility.UrlEncode(Email)
                + "&Password=" + System.Web.HttpUtility.UrlEncode(Password)
                + "&Recipient=" + System.Web.HttpUtility.UrlEncode(Recipient)
                + "&Message=" + System.Web.HttpUtility.UrlEncode(Message);

            byte[] PostData = Encoding.ASCII.GetBytes(RequestData);
            byte[] Response = Client.UploadData(RequestURL, PostData);

            String Result = Encoding.ASCII.GetString(Response);
            int ResultCode = System.Convert.ToInt32(Result.Substring(0, 4));

            return ResultCode;
        }
    }
}