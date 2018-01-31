using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortableRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            Console.WriteLine("Radio controls:");
            int input = 9;
            while (input != 0)
            {
                Console.WriteLine("1: Power on/off \n2: Set volume\n3: Set frequency");
                input = int.Parse(Console.ReadLine());
                switch (input)
                    {
                    case 1:
                        Radio.Power();
                        break;
                    case 2:
                        radio.SetVolume();
                        break;
                    case 3:
                        radio.SetFrequency();
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                    }


            }
        }
    }
}
