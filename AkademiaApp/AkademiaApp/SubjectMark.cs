using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaApp
{
    class SubjectMark
    {
        private string name;
        private int value;

        public SubjectMark( string name, int value)
        {
            this.name = name;
            this.value = value;
        }
    
        public string Name { get => name; set => name = value; }
        public int Value { get => value; set => this.value = value; }
        
    }
}
