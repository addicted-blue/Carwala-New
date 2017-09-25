using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarWala.UI.Models
{
    public class RequestForm
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string Contact { get; set; }

        public string PickUpLocation { get; set; }

        public string Destination { get; set; }


        public string JourneyDate { get; set; }

        public string JourneyTime { get; set; }
    }
}