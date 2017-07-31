using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AkademiaApp.MainWindow;
namespace AkademiaApp
{
    class Teacher :Person
    {
        private academicDegree academicDegree;
        private double salary;

        public Teacher(string name, string surname, string phone, academicDegree academicDegree, double salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phone;
            this.academicDegree = academicDegree;
            this.salary = salary;
        }

        public academicDegree AcademicDegree
        {
            get
            {
                return academicDegree;
            }

            set
            {
                academicDegree = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
    }
}
