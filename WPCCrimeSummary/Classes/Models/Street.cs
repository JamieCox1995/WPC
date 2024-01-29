using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Street
    {
        public int ID { get; } 
        public string Name { get; }

        public Street(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
    }
}
