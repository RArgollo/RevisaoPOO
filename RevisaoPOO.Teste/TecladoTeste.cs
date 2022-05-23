using Xunit;
using RevisaoPOO.Lib.Models;
namespace RevisaoPOO.Teste
{
    public class TecladoTeste
    {
          private Teclado CriaTecladoPadrao()
        {
            return new Teclado(1, "teclado", "razr", true, "teclado gamer", 100, 5, true);
        }

        [Fact]
        public void TesteGetSemFio()
        {
            var teclado = CriaTecladoPadrao();
            teclado.GetSemFio();
            var semFioEsperado = true;
            Assert.Equal(semFioEsperado, teclado.SemFio);
        }

            [Fact]
        public void TesteGetMecanico()
        {
            var teclado = CriaTecladoPadrao();
            teclado.GetMecanico();
            var mecanicoEsperado = true;
            Assert.Equal(mecanicoEsperado, teclado.Mecanico);
        }
        
        [Fact]
        public void TesteCalcularValor()
        {
            var teclado = CriaTecladoPadrao();
            teclado.GetValor();
            var valorEsperado = 345;
            Assert.Equal(valorEsperado, teclado.Valor);
        }
    }
}