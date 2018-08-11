using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace payment
{
    public class ParkingType
    {
        private int _hours;

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                _hours = value;
            }
        }

        public virtual decimal Calculate(int parkingHours)
        {
            throw new System.NotImplementedException();
        } 
    }
}