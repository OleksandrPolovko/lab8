using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public abstract class Processor
    {
        public abstract void Process();
    }

    // Конкретний клас для процесорів смартфона
    public class SmartphoneProcessor : Processor
    {
        public override void Process()
        {
            Console.WriteLine("Smartphone Processor Processing");
        }
    }

    // Конкретний клас для процесорів ноутбука
    public class LaptopProcessor : Processor
    {
        public override void Process()
        {
            Console.WriteLine("Laptop Processor Processing");
        }
    }

}
