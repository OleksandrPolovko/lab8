using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public abstract class TechProductFactory
    {
        public abstract Screen CreateScreen();
        public abstract Processor CreateProcessor();
        public abstract Camera CreateCamera();
    }

    // Конкретна фабрика для смартфонів
    public class SmartphoneFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new SmartphoneScreen();
        }

        public override Processor CreateProcessor()
        {
            return new SmartphoneProcessor();
        }

        public override Camera CreateCamera()
        {
            return new SmartphoneCamera();
        }
    }

    // Конкретна фабрика для ноутбуків
    public class LaptopFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new LaptopScreen();
        }

        public override Processor CreateProcessor()
        {
            return new LaptopProcessor();
        }

        public override Camera CreateCamera()
        {
            return new LaptopCamera();
        }
    }

}
