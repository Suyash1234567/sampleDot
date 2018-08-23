using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAssignment2.Models
{
    public class SportsData
    {
        public List<Sports> Getata()
        {
            List<Sports> player = new List<Sports>
            {
            new Sports { SportsPersonId=1, SportPersonName="Roger Fredrer", SportsName="Lawn Tennis" ,DoesHeOrShePlayNow=true},
            new Sports { SportsPersonId=2, SportPersonName="Sachin Tendulkar", SportsName="Cricket",DoesHeOrShePlayNow=false  },
            new Sports { SportsPersonId=3, SportPersonName="Lebron James", SportsName="Basketball" ,DoesHeOrShePlayNow=true },
            new Sports { SportsPersonId=4, SportPersonName="Diego Maradona", SportsName="Football",DoesHeOrShePlayNow=false  },
            new Sports { SportsPersonId=5, SportPersonName="PT Usha", SportsName="Athletics",DoesHeOrShePlayNow=false  },
            new Sports { SportsPersonId=6, SportPersonName="Carolina Marin", SportsName="Badminton",DoesHeOrShePlayNow=true  }
            };
            return player;
        }
    }
}