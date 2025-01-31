﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Blink1Lib;

namespace Blink1LibDemo 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Blink1LibDemo Begin-------------");
            Blink1 blink1 = new Blink1();

            int count = blink1.enumerate(); 
            Console.WriteLine("detected " + count + " blink(1 devices");

            if (count != 0)
            {
                string serialnum = blink1.getCachedSerial(0);
                Console.WriteLine("blink(1) serial number: " + serialnum);
            }

            blink1.open();

            Console.WriteLine("setting white");
            blink1.setRGB(255, 255, 255);
            Thread.Sleep(2000);

            Console.WriteLine("fading cyan");
            blink1.fadeToRGB(1000, 0, 255, 255);
            Thread.Sleep(2000);

            Console.WriteLine("fading red");
            blink1.fadeToRGB(1000, 255, 0, 0);
            Thread.Sleep(2000);

            Console.WriteLine("fading black");
            blink1.fadeToRGB(1500, 0, 0, 0);
            Thread.Sleep(2000);

            Console.WriteLine("------------Blink1LibDemo End --------------");
            Thread.Sleep(2000);

        }

    }
}
