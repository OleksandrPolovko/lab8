using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public abstract class Screen
    {
        public abstract void Display();
    }

    // Конкретний клас для екранів смартфона
    public class SmartphoneScreen : Screen
    {
        public override void Display()
        {
            Console.WriteLine("Smartphone Screen Displaying");
        }
    }

    // Конкретний клас для екранів ноутбука
    public class LaptopScreen : Screen
    {
        public override void Display()
        {
            Console.WriteLine("Laptop Screen Displaying");
        }
    }
}
