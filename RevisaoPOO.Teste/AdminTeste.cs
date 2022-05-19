using Xunit;
using RevisaoPOO.Lib.Models;
namespace RevisaoPOO.Teste
{
    public class AdminTeste
    {
        private Admin CriaAdminPadrao()
        {
            return new Admin("Rafael", "rafaelargollo22@hotmail.com", "senha123", "12345678978");
        }

        [Fact]
        public void TesteGetCNPJ()
        {
            var admin = CriaAdminPadrao();
            admin.GetCNPJ();
            var CnpjEsperado = "12345678978";
            Assert.Equal(CnpjEsperado, admin.CNPJ);
        }
    }
}