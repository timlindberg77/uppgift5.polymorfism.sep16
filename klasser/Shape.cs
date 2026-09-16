using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift5.polymorfism.sep16.klasser
{
    public class Shape
    {
        //Skapa en klass Shape med en metod GetArea().
        //metod
        public virtual void GetArea()
        {
            Console.WriteLine("GetArea() from Shape class");
        }
    }
}
