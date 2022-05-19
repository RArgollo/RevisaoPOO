using Xunit;
using RevisaoPOO.Lib.Models;
namespace RevisaoPOO.Teste
{
    public class HeadsetTeste
    {
        private Headset CriaHeadsetPadrao()
        {
            return new Headset("h7", "logitech", "h7 gamer", 100, 5, true, true);
        }

        [Fact]
        public void TesteGetSemFio()
        {
            var headset = CriaHeadsetPadrao();
            headset.GetSemFio();
            var semFioEsperado = true;
            Assert.Equal(semFioEsperado, headset.SemFio);
        }

         [Fact]
        public void TesteGetSurround()
        {
            var headset = CriaHeadsetPadrao();
            headset.GetSurround();
            var surroundEsperado = true;
            Assert.Equal(surroundEsperado, headset.Surround);
        }
    }
}