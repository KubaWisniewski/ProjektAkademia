    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static AkademiaApp.MainWindow;

namespace AkademiaApp
{
    class Student : Person
    {
        private int nrIdx;
        private branchOfStudy branchOfStudy;
        public Student(){}

        public Student(string name , string surname, string phone , int nrIdx, branchOfStudy bos)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phone;
            this.nrIdx = nrIdx;
            this.branchOfStudy = bos;
        }

        public int NrIdx
        {
            get
            {
                return nrIdx;
            }

            set
            {
                nrIdx = value;
            }
        }

        public branchOfStudy BranchOfStudy
        {
            get
            {
                return branchOfStudy;
            }

            set
            {
                branchOfStudy = value;
            }
        }
    }
}
