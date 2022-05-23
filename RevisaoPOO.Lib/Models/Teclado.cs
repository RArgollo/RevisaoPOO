namespace RevisaoPOO.Lib.Models
{
    public class Teclado : Produto
    {
        public bool Mecanico { get; set; }

        public Teclado(int id, string nome, string marca, bool semFio, string descricao, double valor, int estoque, bool mecanico) : base(id, nome, marca, semFio, descricao, valor, estoque)
        {
            SetMecanico(mecanico);
        }
        public void SetMecanico(bool mecanico)
        {
            Mecanico = mecanico;
        }

        public bool GetMecanico()
        {
            return Mecanico;
        }

        public override double CalcularValor(double valorBase)
        {
            var valorFinal = valorBase;
            if (Mecanico)
            {
                valorFinal = valorBase + 200;
            }
            if (SemFio)
            {
                valorFinal = valorFinal * 1.15;
            }
            return valorFinal;
        }
    }
}