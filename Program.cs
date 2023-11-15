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
        static void Task3()
        {
            // Користувач вводить тип продукту
            Console.WriteLine("Enter the type of product (Smartphone/Laptop):");
            string productType = Console.ReadLine();

            // Створення відповідної фабрики
            TechProductFactory factory;
            switch (productType.ToLower())
            {
                case "smartphone":
                    factory = new SmartphoneFactory();
                    break;
                case "laptop":
                    factory = new LaptopFactory();
                    break;
                default:
                    Console.WriteLine("Invalid product type");
                    return;
            }

            // Створення та відображення технологічного продукту
            Screen screen = factory.CreateScreen();
            Processor processor = factory.CreateProcessor();
            Camera camera = factory.CreateCamera();

            Console.WriteLine("\nAssembling and Displaying the Product:");
            screen.Display();
            processor.Process();
            camera.Capture();
        }
        static void Task4()
        {
            // Створення шаблонів даних
            var csvTemplate = new CsvDataTemplate { CsvFormat = "CSV Format" };
            var xmlTemplate = new XmlDataTemplate { XmlFormat = "XML Format" };

            // Створення адаптерів
            var csvAdapter = new CsvDataAdapter(csvTemplate);
            var xmlAdapter = new XmlDataAdapter(xmlTemplate);

            // Користувач вводить формат вихідних та цільових даних
            Console.WriteLine("Enter source data format (CSV/XML):");
            string sourceFormat = Console.ReadLine().ToLower();

            Console.WriteLine("Enter target data format (CSV/XML):");
            string targetFormat = Console.ReadLine().ToLower();

            // Вибір відповідних адаптерів
            IDataTemplate sourceTemplate, targetTemplate;
            IDataAdapter sourceAdapter, targetAdapter;

            if (sourceFormat == "csv")
            {
                sourceTemplate = csvTemplate;
                sourceAdapter = csvAdapter;
            }
            else if (sourceFormat == "xml")
            {
                sourceTemplate = xmlTemplate;
                sourceAdapter = xmlAdapter;
            }
            else
            {
                Console.WriteLine("Invalid source data format");
                return;
            }

            if (targetFormat == "csv")
            {
                targetTemplate = csvTemplate;
                targetAdapter = csvAdapter;
            }
            else if (targetFormat == "xml")
            {
                targetTemplate = xmlTemplate;
                targetAdapter = xmlAdapter;
            }
            else
            {
                Console.WriteLine("Invalid target data format");
                return;
            }

            // Клонування шаблонів для даних
            IDataTemplate clonedSourceTemplate = sourceTemplate.Clone();
            IDataTemplate clonedTargetTemplate = targetTemplate.Clone();

            // Симуляція імпорту та експорту даних
            sourceAdapter.ImportData("Source Data");
            targetAdapter.ExportData();
        }

        private static void Main(string[] args)
        {
            Task1();
            //Task2();
            //Task3();
            //Task4();

            // delay to read from screen
            Console.WriteLine("Press any key to finnish this program...");
            Console.Read();
        }
    }
}
