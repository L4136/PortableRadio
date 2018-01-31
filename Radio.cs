using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortableRadio
{
    class Radio
    {
        public static void Power()
        {
            Console.WriteLine("Power (1 = on, 0 = off):");
            int powerInput = int.Parse(Console.ReadLine());

            switch (powerInput)
            {

                case 1:
                    Console.WriteLine("Power is now on.");
                    break;
                case 0:
                    Console.WriteLine("Power is now off.");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;

            }


        }
        private int maxVol = 9;
        private int minVol = 0;
        private int volume;
        private int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= minVol && value <= maxVol) volume = value;
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Set volume (0-9): ");
                    int input = int.Parse(Console.ReadLine());
                    Volume = input;
                }
            }
        }
        public void SetVolume()
        {
            Console.WriteLine("Set volume (0-9): ");
            int input = int.Parse(Console.ReadLine());
            Volume = input;
            Console.WriteLine("Volume set to: " + Volume);
        }

        private double maxFre = 2600.00;
        private double minFre = 2000.00;
        private double freq;
        private double Freq
        {
            get
            {
                return freq;
            }
            set
            {
                if (value >= minFre && value <= maxFre) freq = value;
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Set frequency (2000.00-2600.00): ");
                    double input = double.Parse(Console.ReadLine());
                    Freq = input;
                }
            }
        }
        public void SetFrequency()
        {
            Console.WriteLine("Set frequency (2000.00-2600.00): ");
            double input = double.Parse(Console.ReadLine());
            Freq = input;
            Console.WriteLine("Frequency set to: " + Freq);
        }



    }
}