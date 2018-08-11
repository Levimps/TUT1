using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payment
{
    public class StaffParking : ParkingType
    {
        public override decimal Calculate(int parkingHours)
        {

            if (parkingHours > 24)
            { 
                 ParkingException pe = new ParkingException();
                 throw pe;
            }
            else if(parkingHours <= 10)
            { return 2; }
            else
            { return (2 + (parkingHours - 10) * 2); }

        }
    }
}