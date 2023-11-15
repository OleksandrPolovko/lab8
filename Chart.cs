using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public abstract class Chart
    {
        public abstract void Draw();
    }

    // Конкретний клас для лінійного графіка
    public class LineChart : Chart
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Line Chart");
            // Логіка для малювання лінійного графіка
        }
    }

    // Конкретний клас для стовпчикового графіка
    public class BarChart : Chart
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Bar Chart");
            // Логіка для малювання стовпчикового графіка
        }
    }

    // Конкретний клас для кругової діаграми
    public class PieChart : Chart
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Pie Chart");
            // Логіка для малювання кругової діаграми
        }
    }

}
