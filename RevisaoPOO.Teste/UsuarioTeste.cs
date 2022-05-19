using Xunit;
using RevisaoPOO.Lib.Models;
namespace RevisaoPOO.Teste
{
    public class UsuarioTeste
    {
        private Usuario CriaUsuarioPadrao()
        {
            return new Usuario("Rafael", "rafaelargollo22@hotmail.com", "senha123");
        }

        [Fact]
        public void TesteGetNome()
        {
            var usuario = CriaUsuarioPadrao();
            usuario.GetNome();
            var nomeEsperado = "Rafael";
            Assert.Equal(nomeEsperado, usuario.Nome);
        }

        [Fact]
        public void TesteGetEmail()
        {
            var usuario = CriaUsuarioPadrao();
            usuario.GetEmail();
            var emailEsperado = "rafaelargollo22@hotmail.com";
            Assert.Equal(emailEsperado, usuario.Email);
        }


        [Fact]
        public void TesteGetSenha()
        {
            var usuario = CriaUsuarioPadrao();
            usuario.GetSenha();
            var senhaEsperada = "senha123";
            Assert.Equal(senhaEsperada, usuario.Senha);
        }
    }
}