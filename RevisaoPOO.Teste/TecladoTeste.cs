using Xunit;
using RevisaoPOO.Lib.Models;
namespace RevisaoPOO.Teste
{
    public class TecladoTeste
    {
          private Teclado CriaTecladoPadrao()
        {
            return new Teclado("teclado", "razr", "teclado gamer", 100, 5, true, true);
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
    }
}