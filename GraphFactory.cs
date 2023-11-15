using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public abstract class GraphFactory
    {
        public abstract Chart CreateChart();
    }

    // Конкретна фабрика для лінійного графіка
    public class LineChartFactory : GraphFactory
    {
        public override Chart CreateChart()
        {
            return new LineChart();
        }
    }

    // Конкретна фабрика для стовпчикового графіка
    public class BarChartFactory : GraphFactory
    {
        public override Chart CreateChart()
        {
            return new BarChart();
        }
    }

    // Конкретна фабрика для кругової діаграми
    public class PieChartFactory : GraphFactory
    {
        public override Chart CreateChart()
        {
            return new PieChart();
        }
    }
}
