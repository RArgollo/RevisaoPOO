namespace RevisaoPOO.Lib.Models
{
    public class Mouse : Produto
    {
        public int DPI { get; set; }
        public bool SemFio { get; set; }

        public Mouse(string nome, string marca, string descricao, double valor, int estoque, int dpi, bool semFio) : base(nome, marca, descricao, valor, estoque)
        {
            SetDPI(dpi);
            SetSemFio(semFio);
        }

        public void SetDPI(int dpi)
        {
            DPI = dpi;
        }

        public int GetDPI()
        {
            return DPI;
        }

        public void SetSemFio(bool semFio)
        {
            SemFio = semFio;
        }

        public bool GetSemFio()
        {
            return SemFio;
        }
    }
}