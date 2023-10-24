
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

        public static void println(bool condition, string message)
        {
            if (condition)
            {
                println(message);
            }
        }

        public static void println(string message)
        {
            if (message.Length >= 7 && message[..7].Equals("[event]"))
            {
                log.LogInformation(message.Substring(8, message.Length));
            }
            else if (message.Length >= 7 && message[..7].Equals("[error]"))
            {
                log.LogError(message.Substring(8, message.Length));
            }
            else
            {
                log.LogDebug(message);
            }
        }
    }
}
