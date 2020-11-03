using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Xml.Schema;

namespace Car
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Fiesta";
            myCar.Year = 2005;    
          
            var toyota = new Car()
            {
                Make = "Toyota",
                Model = "Tundra",
                Year = 2015
            };

            var pontiac = new Car("Pontiac", "Firebird", 1975);

            var carList = new List<Car>() { myCar, toyota, pontiac};

            foreach (var vehicle in carList) 
            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Model}, {vehicle.Year}");

            }

            
          
        
            
        }
    }
}
