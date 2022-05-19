namespace RevisaoPOO.Lib.Models
{
    public class Cliente : Usuario
    {
        public string CPF { get; set; }
        public string Endereco { get; set; }

        public Cliente(string nome, string email, string senha, string cpf, string endereco) : base(nome, email, senha)
        {
            SetCPF(cpf);
            SetEndereco(endereco);
        }

        public void SetCPF(string cpf)
        {
            CPF = cpf;
        }

        public string GetCPF()
        {
            return CPF;
        }

        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }

        public string GetEndereco()
        {
            return Endereco;
        }
    }
}