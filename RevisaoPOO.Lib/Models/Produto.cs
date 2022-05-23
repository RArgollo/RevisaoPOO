namespace RevisaoPOO.Lib.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public bool SemFio { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Estoque { get; set; }

        public Produto(int id, string nome, string marca, bool semFio, string descricao, double valorBase, int estoque)
        {
            SetID(id);
            SetNome(nome);
            SetMarca(marca);
            SetSemFio(semFio);
            SetDescricao(descricao);
            SetValor(valorBase);
            SetEstoque(estoque);
        }

        public void SetID(int id)
        {
            ID = id;
        }

        public int GetID()
        {
            return ID;
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

        public void SetSemFio(bool semFio)
        {
            SemFio = semFio;
        }

        public bool GetSemFio()
        {
            return SemFio;
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
            Valor = CalcularValor(Valor);
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

        public void AdicionarEstoque(int quantidadeAdicionada)
        {
            Estoque = Estoque + quantidadeAdicionada;
        }

        public void RemoverEstoque(int quantidadeRemovida)
        {
            Estoque = Estoque - quantidadeRemovida;
        }

        public virtual double CalcularValor(double valorBase)
        {
            var valorFinal = valorBase;
            return valorFinal;
        }
    }
}