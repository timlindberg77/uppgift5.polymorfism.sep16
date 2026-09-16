using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift5.polymorfism.sep16.klasser
{
    public class Circle : Shape
    {
        //Skapa subklasser Circle och Rectangle som skriver över GetArea() med enkla beräkningar.
        //metod
        public override void GetArea()
        {
            Console.WriteLine($"GetArea() from Circle class: Area = {Math.PI * Math.Pow(5, 2)}");
        }
    }
}
