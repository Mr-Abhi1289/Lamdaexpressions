using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceofLamdaExpressions
{
    public  class person
    {
        public string SSN;
        public string name;
        public int age;
        public string address;

        public person(string SSN,string name,int age,string address)
        {
            this.SSN = SSN;
            this.name = name;
            this.age = age;
            this.address = address; 

        }
    }
}
