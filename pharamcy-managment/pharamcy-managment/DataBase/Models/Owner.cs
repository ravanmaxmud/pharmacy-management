using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharamcy_managment.DataBase.Models
{
     class Owner:User
    {
        public Owner( string name, string lastName, string fin) :base(name, lastName, fin)
        {
 
        }
    }
}
