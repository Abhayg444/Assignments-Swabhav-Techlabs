﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC
{
     public abstract class Animal
    {
        public abstract void MakeSound();
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
}
