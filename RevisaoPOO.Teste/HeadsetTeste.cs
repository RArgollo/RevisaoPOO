using Xunit;
using RevisaoPOO.Lib.Models;
namespace RevisaoPOO.Teste
{
    public class HeadsetTeste
    {
        private Headset CriaHeadsetPadrao()
        {
            return new Headset(1, "h7", "logitech",true , "h7 gamer", 100, 5, true);
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
        
        [Fact]
        public void TesteCalcularValor()
        {
            var headset = CriaHeadsetPadrao();
            headset.GetValor();
            var valorEsperado = 600;
            Assert.Equal(valorEsperado, headset.Valor);
        }
    }
}