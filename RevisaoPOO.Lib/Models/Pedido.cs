namespace RevisaoPOO.Lib.Models
{
    public class Pedido
    {
        public Usuario Usuario { get; set; }
        public List<Produto> Produtos { get; set; }
        public double ValorTotal { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }

        public Pedido(Usuario usuario, List<Produto> produtos, double valorTotal, string status, string data)
        {
            SetUsuario(usuario);
            SetProdutos(produtos);
            SetValorTotal(valorTotal);
            SetStatus(status);
            SetData(data);
        }

        public void SetUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }

        public Usuario GetUsuario()
        {
            return Usuario;
        }

        public void SetProdutos(List<Produto> produtos)
        {
            Produtos = produtos;
        }

        public List<Produto> GetProdutos()
        {
            return Produtos;
        }

        public void SetValorTotal(double valorTotal)
        {
            ValorTotal = valorTotal;
        }

        public double GetValorTotal()
        {
            return ValorTotal;
        }

        public void SetStatus(string status)
        {
            Status = status;
        }

        public string GetStatus()
        {
            return Status;
        }

        public void SetData(string data)
        {
            Data = DateTime.Parse(data);
        }

        public DateTime GetData()
        {
            return Data;
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }

        public double FinalizarPedido()
        {            
            for (int i = 0; i < Produtos.Count; i++)
            {
                ValorTotal = ValorTotal + Produtos[i].GetValor();
            }
            return ValorTotal;
        }
    }
}