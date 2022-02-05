using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(15, 30, 45);
            angle.ToRadians();
            Console.ReadKey();
        }
    }
    public class Angle
    {
        public int gradus;
        public int min;
        public int sec;

        public Angle(int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }

        public void ToRadians()
        {
            if (0 > gradus || gradus > 360)
            {
                Console.WriteLine("Угол имеет недопустимое значение");
            }
            else if (0 > min || min > 60)
            {
                Console.WriteLine("Угол имеет недопустимое значение");
            }
            else if (0 > sec || sec > 60)
            {
                Console.WriteLine("Угол имеет недопустимое значение");             
            }
            else
            {
                Console.WriteLine("угол в градусах = {0} градусов {1} минут {2} секунд", gradus, min, sec);
                gradus = gradus + min/60 + sec/3600;
                double rad = gradus * Math.PI / 180;
                rad = Math.Round(rad, 2);
                Console.WriteLine("угол в радианах = {0}", rad);
            }
        }
    }
}
