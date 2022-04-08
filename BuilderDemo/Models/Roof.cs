using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Models
{
    internal class Roof:Room
    {
        public List<Equipment> Equipments { get; set; }
    }

}
