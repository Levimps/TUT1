using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payment
{
    public class CustomerParking : ParkingType
    {
        public override decimal Calculate(int hour)
        {
            if(hour >24)
            {
                ParkingException pe = new ParkingException();
                throw pe;
            }
            else
            {
                decimal total = 0.00M;
                total = hour * 2;
                return total;
            }
            
        }
    }
}