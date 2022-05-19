namespace RevisaoPOO.Lib.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Estoque { get; set; }

        public Produto(string nome, string marca, string descricao, double valor, int estoque)
        {
            SetNome(nome);
            SetMarca(marca);
            SetDescricao(descricao);
            SetValor(valor);
            SetEstoque(estoque);
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public string GetDescricao()
        {
            return Descricao;
        }

        public void SetValor(double valor)
        {
            Valor = valor;
        }

        public double GetValor()
        {
            return Valor;
        }

        public void SetEstoque(int estoque)
        {
            Estoque = estoque;
        }

        public int GetEstoque()
        {
            return Estoque;
        }
    }
}