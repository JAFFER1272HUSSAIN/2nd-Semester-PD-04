using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_1.BL;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ship> shipList = new List<Ship>();
            string option;
            do
            {
                option = Menu();
                if (option == "1")
                {
                    Ship sh = AddShip();
                    shipList.Add(sh);
                }
                else if (option == "2")
                {
                    ShipPosition(shipList);
                }
                else if (option == "3")
                {
                    SerialNumber(shipList);
                }
                else if (option == "4")
                {
                    ChangeDirection(shipList);
                }
                else if (option == "5")
                {
                    break;
                }
            } while (option != "5");
        }
        static string Menu()
        {
            Console.Clear();
            string option;
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship Position");
            Console.WriteLine("3.View Ship Serial Number");
            Console.WriteLine("4.Change Ship Postion");
            Console.WriteLine("5.Exit");
            Console.Write("Your Option: ");
            option  = Console.ReadLine();
            return option;
        }
        static Ship AddShip()
        {
            Console.Clear();
            Angle angle = new Angle();
            Angle angle1 = new Angle();
            Ship ship = new Ship();
            Console.Write("Enter Ship Serial Number: ");
            ship.serial_number = Console.ReadLine();
            Console.WriteLine("Enter Ship's Latitude....");
            Console.WriteLine("Enter Degree: ");
            angle.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minute: ");
            angle.minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Direction: ");
            angle.letter = char.Parse(Console.ReadLine());
            ship.latitude = angle;
            Console.WriteLine("Enter Ship's Longitutde....");
            Console.WriteLine("Enter Degree: ");
            angle1.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minute: ");
            angle1.minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Direction: ");
            angle1.letter = char.Parse(Console.ReadLine());
            ship.longitude = angle1;
            return ship;
        }
        static void ShipPosition(List<Ship> sh)
        {
            Console.Clear();
            string ship;
            string lat = "", longi = "";
            Console.WriteLine("Enter Ship's Serial Number: ");
            ship = Console.ReadLine();
            foreach(Ship ship2 in sh)
            {
                if(ship2.serial_number == ship)
                {
                    lat = ship2.Lat();
                    longi = ship2.Longi();
                    Console.WriteLine("Latitude is: "+ lat);
                    Console.WriteLine("Longitude is: " + longi);
                }
            }
            Console.ReadKey();
        }
        static void SerialNumber(List<Ship> ship)
        {
            string lat,longi;
            Console.Clear();
            int degreelat, degreelongi;
            float minuteslat,minuteslongi;
            char letterlat,letterlongi;
            Console.WriteLine("Enter Ship's Latitude....");
            Console.WriteLine("Enter Degree: ");
            degreelat = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minute: ");
            minuteslat = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Direction: ");
            letterlat = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship's Longitutde....");
            Console.WriteLine("Enter Degree: ");
            degreelongi = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minute: ");
            minuteslongi = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Direction: ");
            letterlongi = char.Parse(Console.ReadLine());
            longi = degreelongi + "\u00b0" + minuteslongi + "'" + " " + letterlongi;
            lat = degreelat + "\u00b0" + minuteslat + "'" + " " + letterlat;
            foreach (Ship s in ship)
            {
                if(s.Longi() == longi && s.Lat() == lat)
                {
                    Console.WriteLine("Serial Number: " + s.serial_number);
                }
            }
            Console.ReadKey();
        }
        static void ChangeDirection(List<Ship> ship)
        {
            Console.Clear();
            string srnumber;
            Console.WriteLine("Enter Ship's Serial Number: ");
            srnumber = Console.ReadLine();
            int degreelat, degreelongi;
            float minuteslat, minuteslongi;
            char letterlat, letterlongi;
            Console.WriteLine("Enter Ship's Latitude....");
            Console.WriteLine("Enter Degree: ");
            degreelat = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minute: ");
            minuteslat = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Direction: ");
            letterlat = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship's Longitutde....");
            Console.WriteLine("Enter Degree: ");
            degreelongi = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minute: ");
            minuteslongi = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Direction: ");
            letterlongi = char.Parse(Console.ReadLine());
            Angle angle = new Angle(degreelat, minuteslat, letterlat);
            angle.ChangeAngle();
            Angle angle1 = new Angle(degreelongi, minuteslongi, letterlongi);
            angle1.ChangeAngle();
            foreach (Ship s in ship)
            {
                if (srnumber == s.serial_number)
                {
                    s.latitude = angle;
                    s.longitude = angle1;
                }
            }
        }
    }
}
