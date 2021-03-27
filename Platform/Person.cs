using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform
{
    class Person
    {

        public double _day { get; private set; }
        public double _salary { get; private set; }

        public Person (double day, double salary)
        {
            _day = day;
            _salary = salary;
        }

        public double SalaryForday()
        {
            return _salary / _day;
        }
         
        public string IncomePerson()
        {
            if (SalaryForday() < 2.0)
            {
               return  "Poor";
            }
            else if (SalaryForday() <= 10.0)
            {
                return "Low Income";
            }
            else if (SalaryForday() <= 20.0)
            {
                return "Middle Income";
            }
            else if (SalaryForday() <= 50.0)
            {
                return "Upper Middle-Income";
            }
            else if (SalaryForday() > 50.0)
            {
                return "Hight Income";
            }
            else
            {
                return "unknown";
            }
        }
        
 

    }
}
