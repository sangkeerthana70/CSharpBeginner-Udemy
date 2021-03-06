﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullDozer
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.Count(10);
            worker.Count(25);

            worker.Count(5.5);
        }
    }

    public class FactoryWorker
    {
        //property
        public double total { get; set; }
        //constructor
        public FactoryWorker()
        {
            
        }

        // method
        public void Count(int number)
        {
            //if (total == null)
                //total = 0;
            total = total + Convert.ToSingle(number);
            Console.WriteLine(total.ToString());
        }

        public void Count(double number)
        {
            total = total + number;
            Console.WriteLine(total.ToString());

        } 
    }
}
