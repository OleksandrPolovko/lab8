using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main()
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
    }
}
