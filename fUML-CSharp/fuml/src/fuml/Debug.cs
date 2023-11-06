
using Microsoft.Extensions.Logging;

namespace fuml
{
    public class Debug
    {
        private static readonly ILogger log = LoggerFactory.Create(
            builder => builder
                            .AddConsole()
                            .SetMinimumLevel(LogLevel.Debug)
            ).CreateLogger(typeof(Debug));

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
                log.LogInformation("$Message", message.Substring(8, message.Length));
            }
            else if (message.Length >= 7 && message[..7].Equals("[error]"))
            {
                log.LogError("$Message", message.Substring(8, message.Length));
            }
            else
            {
                log.LogDebug("$Message", message);
            }
        }
    }
}
