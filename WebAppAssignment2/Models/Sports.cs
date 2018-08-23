using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAssignment2.Models
{
    public class Sports
    {
        public string SportPersonName
        {
            get; set;
        }
        public int SportsPersonId
        {
            get; set;
        }
        public string SportsName
        {
            get; set;
        }
        public bool DoesHeOrShePlayNow 
        {
            get; set;
        }
    }
}