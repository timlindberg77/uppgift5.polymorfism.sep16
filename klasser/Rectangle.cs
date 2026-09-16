using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift5.polymorfism.sep16.klasser
{
    public class Rectangle : Shape
    {
        //Skapa subklasser Circle och Rectangle som skriver över GetArea() med enkla beräkningar.
        //metod
        public override void GetArea()
        {
            Console.WriteLine($"GetArea() from Rectangle class: Area = {5 * 10}");
        }
    }
}
