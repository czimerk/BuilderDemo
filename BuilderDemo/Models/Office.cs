using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Models
{
    internal class Office
    {
        public Entrance Entrance { get; set; }
        public List<Floor> Floors { get; set; }
        public ParkingLot ParkingLot { get; set; }
    }
}
