using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.BL
{
    internal class Angle
    {
        public Angle()
        {
            degree = 0;
            minutes = 0;
            letter = ' ';
        }
        public Angle(int degree,float minutes,char letter)
        {
            this.degree = degree;
            this.minutes = minutes;
            this.letter = letter;
        }
        public string ChangeAngle()
        {
            direction = degree + "\u00b0" + minutes + "'" + " " + letter;
            return direction;
        }
        public string direction;
        public int  degree;
        public float minutes;
        public char letter;
    }
}
