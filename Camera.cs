using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public abstract class Camera
    {
        public abstract void Capture();
    }

    // Конкретний клас для камер смартфона
    public class SmartphoneCamera : Camera
    {
        public override void Capture()
        {
            Console.WriteLine("Smartphone Camera Capturing");
        }
    }

    // Конкретний клас для камер ноутбука
    public class LaptopCamera : Camera
    {
        public override void Capture()
        {
            Console.WriteLine("Laptop Camera Capturing");
        }
    }
}
