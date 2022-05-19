namespace RevisaoPOO.Lib.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario(string nome, string email, string senha)
        {
            SetNome(nome);
            SetEmail(email);
            SetSenha(senha);
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SetSenha(string senha)
        {
            Senha = senha;
        }

        public string GetSenha()
        {
            return Senha;
        }
    }

}