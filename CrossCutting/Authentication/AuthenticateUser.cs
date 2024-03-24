namespace CrossCutting.Authentication
{
    public class Authentication
    {
        public static bool AuthenticateUser(string username, string password)
        {
            // Lógica de autenticação do usuário, por exemplo, verificando se as credenciais estão corretas no banco de dados.
            // Retorna verdadeiro se o usuário for autenticado com sucesso, falso caso contrário.
            return (username == "admin" && password == "password");
        }
    }
}
