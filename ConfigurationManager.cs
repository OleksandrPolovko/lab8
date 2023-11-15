using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;

        // Конфігураційні налаштування
        public string LogLevel { get; set; }
        public string DatabaseConnectionString { get; set; }

        // Заборона створення екземплярів ззовні
        private ConfigurationManager() { }

        // Отримання єдиного екземпляру ConfigurationManager
        public static ConfigurationManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationManager();
                }
                return _instance;
            }
        }

        // Метод для виведення конфігураційних налаштувань
        public void DisplayConfiguration()
        {
            Console.WriteLine($"LogLevel: {LogLevel}");
            Console.WriteLine($"DatabaseConnectionString: {DatabaseConnectionString}");
        }
    }
}
