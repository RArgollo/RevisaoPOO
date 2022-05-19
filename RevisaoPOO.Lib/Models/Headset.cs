namespace RevisaoPOO.Lib.Models
{
    public class Headset : Produto
    {
        public bool SemFio { get; set; }
        public bool Surround { get; set; }

        public Headset(string nome, string marca, string descricao, double valor, int estoque, bool semFio, bool surround) : base(nome, marca, descricao, valor, estoque)
        {
            SetSemFio(semFio);
            SetSurround(surround);
        }

        public void SetSemFio(bool semFio)
        {
            SemFio = semFio;
        }

        public bool GetSemFio()
        {
            return SemFio;
        }

        public void SetSurround(bool surround)
        {
            Surround = surround;
        }

        public bool GetSurround()
        {
            return Surround;
        }
    }
}