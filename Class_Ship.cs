using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.BL
{
    internal class Ship
    {
        public Ship()
        {
            serial_number = "";
            direction = "";
        }
        public Ship(string serial_number)
        {
            this.serial_number = serial_number;
        }
        public Ship(string serial_number,string direction)
        {
            this.serial_number = serial_number;
            this.direction = direction;
        }
        public string Lat()
        {
            string l;
            l = latitude.ChangeAngle();
            return l;
        }
        public string Longi()
        {
            string l;
            l = longitude.ChangeAngle();
            return l;
        }
        public Angle latitude;
        public Angle longitude;
        public string serial_number;
        public string direction;
    }
}
