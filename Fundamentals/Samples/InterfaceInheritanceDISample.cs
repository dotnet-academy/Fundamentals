using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals.Samples
{
    public static class InterfaceInheritanceDISample
    {
        public static void Demo()
        {
            Helpers.DisplaySectionTitle("Interface inheritance - Dependency injection");

            // Calculator class accepts an ILog type in its ctor
            // so all implementations of ILog will work!
            {
                var calc = new Calculator(new ConsoleLog());
                calc.Divide(1.0m, 0); // division by zero exception will be logged in the screen
            }

            {
                var calc = new Calculator(new FileLog(Environment.CurrentDirectory));
                calc.Divide(1.0m, 0); // division by zero exception will be logged in the file path
            }

            Helpers.DisplaySectionEnd();
        }
    }

    public class Calculator
    {
        private readonly ILog _log;

        public Calculator(ILog log)
        {
            _log = log;
        }

        public decimal? Divide(decimal a, decimal b)
        {
            decimal? result = null;

            try
            {
                result = a / b;
            }
            catch (Exception ex)
            {
                _log.Write(ex.Message, DateTime.Now);
            }

            return result;
        }
    }

    public interface ILog
    {
        void Write(string message, DateTime date);
    }

    public class FileLog : ILog
    {
        private readonly string _logPath;

        public FileLog(string filePath)
        {
            if (!System.IO.Directory.Exists(filePath))
            {
                System.IO.Directory.CreateDirectory(filePath);
            }

            _logPath = $@"{filePath}\log.txt";
        }

        public void Write(string message, DateTime date)
        {
            var text = $"{message} {date.ToString("yyyy-MM-dd HH:mm:ss:ffff")}" + Environment.NewLine;
            System.IO.File.AppendAllText(_logPath, text);
        }
    }

    public class ConsoleLog : ILog
    {
        public void Write(string message, DateTime date)
        {
            var text = $"{message} {date.ToString("yyyy-MM-dd HH:mm:ss:ffff")}";
            Console.WriteLine(text);
        }
    }
}
