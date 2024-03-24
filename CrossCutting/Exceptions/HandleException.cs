namespace CrossCutting.Exceptions
{
    internal class ExceptionHandler
    {
        public static void HandleException(Exception ex)
        {
            // Implementação do tratamento de exceções, por exemplo, logar a exceção e notificar o administrador do sistema.
            Console.WriteLine($"[ERROR]: {ex.Message}");
            // Código para notificar o administrador por email, etc.
        }
      
        public static void NotFoundException(string Message)
        {
            Console.WriteLine($"[ERRO]: {Message}");
        }
    }
}
