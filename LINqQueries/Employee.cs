using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINqQueries
{
    class Employee
    {
        public string FirstName { get; }//read-only auto-implemented porperty
        public string LastName { get; }//read-only auto-implemented property
        private decimal monthlySalary;//monthly salary of employee

        //constructor initializes first name, last name and monthly salary
        public Employee(string firstName,string lastName,
            decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        //property that gets and sets the employee's monthly salary
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if(value >= 0M)
                {
                    monthlySalary = value;
                }
            }
        }

        //return a string containing the employee's information
        public override string ToString() => $"{FirstName,-10} {LastName,-10} ${MonthlySalary,10}";
    }
}
