using Xunit;
using RevisaoPOO.Lib.Models;
namespace RevisaoPOO.Teste
{
    public class MouseTeste
    {
         private Mouse CriaMousePadrao()
        {
            return new Mouse("mouse", "logitech", "mouse gamer", 100, 5, 6000, true);
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
    }
}