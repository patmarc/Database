using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    abstract class Person
    {
        public string sFirstName { get; set; }
        public string sLastName { get; set; }
        public int iAge { get; set; }
        public string sPersonIdentifier { get; set; }
        public enum eWho: int { Doctor = 1, Patient = 0};
    }


}
