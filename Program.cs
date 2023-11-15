using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Task1()
        {
            // Отримання єдиного екземпляру ConfigurationManager
            ConfigurationManager configManager = ConfigurationManager.Instance;

            // Виведення початкових конфігураційних налаштувань
            configManager.DisplayConfiguration();

            // Зміна конфігураційних налаштувань через консольний інтерфейс
            Console.WriteLine("\nEnter new configuration settings:");
            Console.Write("LogLevel: ");
            configManager.LogLevel = Console.ReadLine();

            Console.Write("DatabaseConnectionString: ");
            configManager.DatabaseConnectionString = Console.ReadLine();

            // Виведення змінених конфігураційних налаштувань
            Console.WriteLine("\nUpdated configuration settings:");
            configManager.DisplayConfiguration();

            // Перевірка, що зміни відображаються у єдиному екземплярі ConfigurationManager
            ConfigurationManager anotherConfigManager = ConfigurationManager.Instance;
            Console.WriteLine("\nConfiguration settings from another instance:");
            anotherConfigManager.DisplayConfiguration();
        }

            static void Task2()
            {
                // Користувач вводить тип графіка
                Console.WriteLine("Enter the type of chart (Line/Bar/Pie):");
                string chartType = Console.ReadLine();

                // Створення відповідної фабрики
                GraphFactory factory;
                switch (chartType.ToLower())
                {
                    case "line":
                        factory = new LineChartFactory();
                        break;
                    case "bar":
                        factory = new BarChartFactory();
                        break;
                    case "pie":
                        factory = new PieChartFactory();
                        break;
                    default:
                        Console.WriteLine("Invalid chart type");
                        return;
                }

                // Створення та відображення графіка
                Chart chart = factory.CreateChart();
                chart.Draw();
            }
        
        private static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();

            // delay to read from screen
            Console.WriteLine("Press any key to finnish this program...");
            Console.Read();
        }
    }
}
