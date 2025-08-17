using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Employee
    {
        public int Age { get; set; }

        public bool IsAdult(int age)
        {
            if (age < 60)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}
