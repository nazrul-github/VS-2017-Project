﻿using System;

namespace ConstructorsAndInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumberr;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumberr = registrationNumber;
            Console.WriteLine("Vehicle is being initialized. {0}",registrationNumber);
        }
    }
}