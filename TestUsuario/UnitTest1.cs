using Entidades;
using Xunit.Sdk;

namespace TestUsuario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BuscarUsuarioExistente()
        {   
            // Arrange
            string mail = "usuario@parcial.com";
            string contrase�a = "Contrase�a123.";
            Usuario usuario = new Usuario(mail, contrase�a);
            List<Usuario> listaPrueba = new List<Usuario>();
            listaPrueba.Add(usuario);

            // Act
            int retorno = Usuario.FindUser(usuario, listaPrueba);


            // Assert
            Assert.IsNotNull(retorno);
            Assert.AreNotEqual(-1, retorno);
            Assert.AreEqual(mail, usuario.Mail);
            Assert.AreEqual(contrase�a, usuario.Contrase�a);

        }

        [TestMethod]
        public void BuscarUsuarioInexistente()
        {
            // Arrange
            string mail = "usuario@parcial.com";
            string contrase�a = "Contrase�a123.";
            Usuario usuario = new Usuario(mail, contrase�a);
            List<Usuario> listaPrueba = new List<Usuario>();

            // Act
            int retorno = Usuario.FindUser(usuario, listaPrueba);


            // Assert
            Assert.IsNotNull(retorno);
            Assert.AreEqual(-1, retorno);
        }
    }
}