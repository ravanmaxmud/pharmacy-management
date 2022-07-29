using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharamcy_managment.DataBase.Models
{
    abstract class User
    {
        public static int Id { get; set; }
        public string Name { get; set; }        
        public string LastName { get; set; }
        public string Fin { get; set; }
        public User(int id,string name,string lastName,string fin)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Fin = fin;
        }
    }
}
