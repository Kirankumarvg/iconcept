using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiran.Library.shapes
{
    public class Employee
    {
        string _FirstName;
        string _LastName;
        float _salary;
        public Employee(string firstName )
        {
            this._FirstName = firstName;
            //this._LastName =  
        }

        //public Employee(string firstName)
        public Employee(int salary)
        {
            this._salary = salary;
        }

        public float DoIncriment()
        {
            float myIncriment;
            myIncriment = 10 / 100 * _salary;
            return myIncriment;
        }
    }
}
