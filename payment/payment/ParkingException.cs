using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace payment
{
    public class ParkingException: ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Your car has been towed away";
            }
        }
    }
}