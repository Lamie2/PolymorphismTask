using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Student:Person
    {
        public Student(string name, string surname, byte age, double IQRank, double LanguageRank):base(name, surname, age)
        {
            this._iQRank = IQRank;
            this._languageRank = LanguageRank;
        }
        private double _age;
        private double _iQRank;
        private double _languageRank;

        public double Age { get => _age;
            set
            {
                if (!(value<6 && value>20))
                {
                    _age = value;
                }
            }
        }
        public double IQRank { get => _iQRank; 
            set {
                if (value>=0 && value<=100)
                {
                    _iQRank = value;
                }
                }
            }
        public double LanguageRank { get => _languageRank;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _languageRank = value;
                }
            }
        }
        public void ExamResult()
        {
            if (IQRank+LanguageRank<120)
            {
                Console.WriteLine("student sinifde qalib :/");
            }
        }
    }
}
