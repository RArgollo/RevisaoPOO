namespace RevisaoPOO.Lib.Models
{
    public class Headset : Produto
    {
        public bool Surround { get; set; }

        public Headset(int id, string nome, string marca, bool semFio, string descricao, double valor, int estoque, bool surround) : base(id, nome, marca, semFio, descricao, valor, estoque)
        {
            SetSurround(surround);
        }
        public void SetSurround(bool surround)
        {
            Surround = surround;
        }

        public bool GetSurround()
        {
            return Surround;
        }

        public override double CalcularValor(double valorBase)
        {
            var valorFinal = valorBase;
            if (Surround && SemFio)
            {
                valorFinal = valorBase + 500;
            }
            else if (Surround || SemFio)
            {
                valorFinal = valorFinal + 150;
            }
            return valorFinal;
        }
    }
}