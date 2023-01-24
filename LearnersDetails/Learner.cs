using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnersDetails
{
     class Learner
    {
        public string firstname;
        public string lastname;
        public string gender;
        public int age;
        public char initial;

        public  Learner (string firstname, string lastname, string gender, int age, char initial)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.age = age;
            this.initial = initial;
        }
    }
}
