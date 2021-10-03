using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTasks.Models
{
    public abstract class Employee
    {

        protected String F_Name;
        protected String L_Name;
        protected String Email;
        protected int Phone;

        public String _F_Name
        {
            set { F_Name = value; }
            get { return F_Name; }
        }

        public String _L_Name
        {
            set { L_Name = value; }
            get { return L_Name; }
        }

        public String _Email
        {
            set { Email = value; }
            get { return Email; }
        }

        public int _Phone
        {
            set { Phone = value; }
            get { return Phone; }
        }

        public abstract bool Check();
        public abstract double Calc();


        public String Print(double salary, string Type)
        {
            string msg = "Hello, " + F_Name +" "+ L_Name +". this is "+ Type + " Employee, your salary is :" + salary;
            return msg;
        }
    }
}
