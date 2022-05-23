using Xunit;
using RevisaoPOO.Lib.Models;
namespace RevisaoPOO.Teste
{
    public class MouseTeste
    {
        private Mouse CriaMousePadrao()
        {
            return new Mouse(1, "mouse", "logitech", true, "mouse gamer", 100, 5, 6000);
        }

        [Fact]
        public void TesteGetDPI()
        {
            var mouse = CriaMousePadrao();
            mouse.GetNome();
            var dpiEsperado = 6000;
            Assert.Equal(dpiEsperado, mouse.DPI);
        }

        [Fact]
        public void TesteGetSemFio()
        {
            var mouse = CriaMousePadrao();
            mouse.GetSemFio();
            var semFioEsperado = true;
            Assert.Equal(semFioEsperado, mouse.SemFio);
        }

        [Fact]
        public void TesteCalcularValor()
        {
            var mouse = CriaMousePadrao();
            mouse.GetValor();
            var valorEsperado = (100 + (6000 / 50)) * 1.15;
            Assert.Equal(valorEsperado, mouse.Valor);
        }
    }
}