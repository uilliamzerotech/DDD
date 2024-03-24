using System.Text.RegularExpressions;

namespace CrossCutting.Validation
{
    public class InputValidator
    {
        public static bool ValidateEmail(string email)
        {
            // Lógica de validação do email, por exemplo, usando expressões regulares.
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            // Lógica de validação do número de telefone, por exemplo, verificando o formato.
            return Regex.IsMatch(phoneNumber, @"^\d{3}-\d{3}-\d{4}$");
        }
    }
}
