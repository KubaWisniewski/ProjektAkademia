using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaApp
{
    class Mark
    {
        private int id;
        private int value;
        private int idStudent;
        private int idSubject;


        public Mark(int value, int idStu,int idSub)
        {
            this.idStudent = idStu;
            this.IdSubject = idSub;
            this.Value = value;
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
        public int IdStudent
        {
            get
            {
                return idStudent;
            }

            set
            {
                idStudent = value;
            }
        }
        public int IdSubject
        {
            get
            {
                return idSubject;
            }

            set
            {
                idSubject = value;
            }
        }
    }
}
