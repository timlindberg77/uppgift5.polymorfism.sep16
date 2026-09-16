using uppgift5.polymorfism.sep16.klasser;

namespace uppgift5.polymorfism.sep16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //I Main, skapa ett Circle- och ett Rectangle-objekt och anropa GetArea() på båda.
             Circle C1 = new Circle();
            C1.GetArea();

            Rectangle R1 = new Rectangle();
            R1.GetArea();
        }
    }
}
