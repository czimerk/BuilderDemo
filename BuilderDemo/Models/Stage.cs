using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Models
{
    internal class Stage
    {
        public int Id { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
