namespace RevisaoPOO.Lib.Models
{
    public class Admin : Usuario
    {
        public string CNPJ { get; set; }

        public Admin(string nome, string email, string senha, string cnpj) : base(nome, email, senha)
        {
            SetCNPJ(cnpj);
        }

        public void SetCNPJ(string cnpj)
        {
            CNPJ = cnpj;
        }

        public string GetCNPJ()
        {
            return CNPJ;
        }
    }
}