using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTasks.Models
{
    public class DailyEmployee:Employee
    {
        int Day;
        double Day_Price;

        public int _Day
        {
            set { Day = value; }
            get { return Day; }
        }

        public double _Day_Price
        {
            set { Day_Price = value; }
            get { return Day_Price; }
        }

        
        public override bool Check()
        {
            if(F_Name != "" && L_Name != "" && Email != "" && Phone != 0 && Day != 0 && Day_Price != 0)
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
            double Salary = (Day * Day_Price);
            return Salary;
        }

        

    }
}
