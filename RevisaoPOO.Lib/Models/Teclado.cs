namespace RevisaoPOO.Lib.Models
{
    public class Teclado : Produto
    {
        public bool SemFio { get; set; }
        public bool Mecanico { get; set; }

        public Teclado(string nome, string marca, string descricao, double valor, int estoque, bool semFio, bool mecanico) : base(nome, marca, descricao, valor, estoque)
        {
            SetSemFio(semFio);
            SetMecanico(mecanico);
        }

        public void SetSemFio(bool semFio)
        {
            SemFio = semFio;
        }

        public bool GetSemFio()
        {
            return SemFio;
        }

        public void SetMecanico(bool mecanico)
        {
            Mecanico = mecanico;
        }

        public bool GetMecanico()
        {
            return Mecanico;
        }
    }
}