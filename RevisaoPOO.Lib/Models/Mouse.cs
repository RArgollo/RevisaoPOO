namespace RevisaoPOO.Lib.Models
{
    public class Mouse : Produto
    {
        public int DPI { get; set; }


        public Mouse(int id, string nome, string marca, bool semFio, string descricao, double valor, int estoque, int dpi) : base(id, nome, marca, semFio, descricao, valor, estoque)
        {
            SetDPI(dpi);
        }

        public void SetDPI(int dpi)
        {
            DPI = dpi;
        }

        public int GetDPI()
        {
            return DPI;
        }
        public override double CalcularValor(double valorBase)
        {
            var valorFinal = valorBase + (DPI / 50);
            if (SemFio)
            {
                valorFinal = valorFinal * 1.15;
                return valorFinal;
            }
            return valorFinal;
        }
    }
}