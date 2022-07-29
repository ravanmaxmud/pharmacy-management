using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharamcy_managment.DataBase.Models
{
     class Drugist :User
    {
        public string Education { get; set; }
        public string Experience { get; set; }
        public Drugist(string name, string lastName, string fin,string education,string experience) : base(name, lastName, fin)
        {
           Education = education;
            Experience = experience;
        }
    }
}
