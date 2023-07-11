using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_2_1
{
    public enum LogType
    {
        Error,
        Info,
        Warning,
    }
    public class Logger
    {
        public static Logger _logger;

        private StringBuilder _result;

        static Logger()
        {
            _logger = new Logger();
        }

        private Logger()
        {
            _result = new StringBuilder();
        }

        public static Logger Instance
        {
            get
            {
                return _logger;
            }
        }

        public void Log(LogType logType, string message)
        {
            _result.AppendLine($"{DateTime.Now} {logType} {message}.");
        }

        public void LogError(string message)
        {
            Log(LogType.Error, message);
        }

        public string GetMessage()
        {
            return _result.ToString();
        }
    }
}