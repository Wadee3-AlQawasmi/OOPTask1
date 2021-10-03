using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTasks.Models
{
    public class HourlyEmployee:Employee
    {

        int Hours;
        double Hour_Price;

        public int _Hours
        {
            set { Hours = value; }
            get { return Hours; }
        }

        public double _Hour_Price
        {
            set { Hour_Price = value; }
            get { return Hour_Price; }
        }

        public override bool Check()
        {
            if (F_Name != "" && L_Name != "" && Email != "" && Phone != 0 && Hours != 0 && Hour_Price != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double Calc()
        {
            double Salary = (Hours * Hour_Price);
            return Salary;
        }


    }
}
