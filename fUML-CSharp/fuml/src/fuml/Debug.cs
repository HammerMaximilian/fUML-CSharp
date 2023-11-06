//using Microsoft.Extensions.Logging;

namespace fuml
{
    public class Debug
    {
        /*private static readonly ILogger log = LoggerFactory.Create(
            builder => builder
                            .AddConsole()
                            .SetMinimumLevel(LogLevel.Debug)
            ).CreateLogger(typeof(Debug));*/

        public static void Println(bool condition, string message)
        {
            if (condition)
            {
                Println(message);
            }
        }

        public static void Println(string message)
        {
            if (message.Length >= 7 && message[..7].Equals("[event]"))
            {
                //log.LogInformation("$Message", message.Substring(8, message.Length));
                LOG_INFO(message);
            }
            else if (message.Length >= 7 && message[..7].Equals("[error]"))
            {
                //log.LogError("$Message", message.Substring(8, message.Length));
                LOG_ERROR(message);
            }
            else
            {
                //log.LogDebug("$Message", message);
                LOG_DEBUG(message);
            }
        }

        private static void LOG_INFO(string message)
        {
#if DEBUG
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("INFO");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]:\t\t" + message);
#endif
        }

        private static void LOG_DEBUG(string message)
        {
#if DEBUG
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("DEBUG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]:\t\t" + message);
#endif
        }

        private static void LOG_ERROR(string message)
        {
#if DEBUG
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERROR");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]:\t\t" + message);
#endif
        }
    }
}
