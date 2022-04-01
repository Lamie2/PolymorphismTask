using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Employee:Person
    {
        public Employee(string name, string surname, byte age, double salaryOfHour, double workingHour):base(name, surname, age)
        {
            this.SalaryOfHour = salaryOfHour;
            this._workingHour = workingHour;
        }
        private byte _age;
        public byte age
        {
            get => _age;
            set
            {
                if (value>18)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("isleme huququ yoxdur!");
                }
            }
        }
        public double SalaryOfHour;
        private double _workingHour;
        private double _salaryOfMonth;
        public double WorkingHour { get => _workingHour;
                set
            {
                if (value<8)
                {
                    _workingHour = value;
                }
            } 
        }

        public double SalaryOfMonth
        {
            get => _salaryOfMonth;
            set
            {
                if (value>250)
                {
                    _salaryOfMonth = value;
                }
            }
        }
        public void CalculateSalary()
        {
            double SalaryOfMonth = 0;
            SalaryOfMonth = SalaryOfHour * _workingHour;

        }
    }
}
