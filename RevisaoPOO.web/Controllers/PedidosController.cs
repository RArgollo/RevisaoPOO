using RevisaoPOO.Lib.Models;
using RevisaoPOO.Lib.Exceptions;
using Microsoft.AspNetCore.Mvc;
namespace RevisaoPOO.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {
        public static List<Produto> ProdutosDisponiveis { get; set; } = new List<Produto>();
        public static List<Produto> ProdutosEscolhidos { get; set; } = new List<Produto>();
        public static Usuario Usuario { get; set; } = new Usuario("Rafael", "rafaelargollo22@hotmail.com", "senha123");
        public static Pedido Pedido { get; set; } = new Pedido(Usuario, ProdutosEscolhidos, 0, "Comprando", "22/05/2022");
        
        

        [HttpGet("Produtos disponíveis")]
        public IActionResult ProdutosDisponiveisParaCompra()
        {
            ProdutosDisponiveis.Add(new Headset(1, "h7", "logitech", true, "h7 gamer", 100, 5, true));
            ProdutosDisponiveis.Add(new Mouse(2, "mouse", "logitech", true, "mouse gamer", 150, 5, 6000));
            ProdutosDisponiveis.Add(new Teclado(1, "teclado", "razr", true, "teclado gamer", 80, 5, true));
            return Ok(ProdutosDisponiveis);
        }

        [HttpPost("AddProduto")]
        public IActionResult AddProduto(Produto produto)
        {
            Pedido.AdicionarProduto(produto);
            return Ok(ProdutosEscolhidos);
        }

        [HttpDelete("RemoverProduto")]
        public IActionResult RemoverProduto(Produto produto)
        {
            try
            {
                Pedido.RemoverProduto(produto);
                return Ok(ProdutosEscolhidos);
            }
            catch (ValorInvalidoException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Pedido final")]
        public IActionResult PedidoFinal()
        {
            return Ok(Pedido.FinalizarPedido);
        }

        [HttpPost("NovoPedido")]
        public IActionResult NovoPedido()
        {
            ProdutosEscolhidos = new List<Produto>();
            Pedido = new Pedido(Usuario, ProdutosEscolhidos, 0, "Comprando", "22/05/2022");
            return Ok(Pedido);
        }

    }
}