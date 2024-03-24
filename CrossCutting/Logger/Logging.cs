namespace CrossCutting.Logger
{
    public class Logging
    {
        public static void Log(string message)
        {
            // Implementação do log, por exemplo, usando um framework de logging como Serilog, NLog, etc.
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
