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
        /*
       
        public void VolumeSet()
        {
            Console.WriteLine("Set Volume ({0},...,{1}): ", volumeMin, volumeMax);
            int input = int.Parse(Console.ReadLine());
            Volume = input;
            Console.WriteLine("Volume is: " + Volume);
        }
        public void FrequencySet()
        {
            Console.WriteLine("Set Frequency ({0},...,{1}); ", frequencyMin, frequencyMax);
            double input = double.Parse(Console.ReadLine());
            Frequency = input;
            Console.WriteLine("Frequency is: " + Frequency);
        }
        public void PrintInfo()
        {
            Console.WriteLine("Current status:");
            Console.WriteLine("Power is: " + Power);
            Console.WriteLine("Volume is: " + Volume);
            Console.WriteLine("Frequency is: " + Frequency);
        }
        private bool Power { get; set; }
        private int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= volumeMin && value <= volumeMax) volume = value;
                else Console.WriteLine("User input is invalid");
            }
        }
        private double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value >= frequencyMin && value <= frequencyMax) frequency = value;
                else Console.WriteLine("User input is invalid");
            }
        }
        private bool power = false;
        private int volume;
        private int volumeMin = 0;
        private int volumeMax = 9;
        private double frequency;
        private double frequencyMin = 2000.0;
        private double frequencyMax = 26000.0;
    }*/
    }

