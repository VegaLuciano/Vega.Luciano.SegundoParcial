using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LogearUsuario_UsuarioExistente_DevuelveUsuario()
        {
            // Arrange
            string correo = "a@a";
            string contraseña = "1234";
        

            // Act
        

            // Assert
            Assert.IsNotNull(usuario);
            Assert.AreEqual(correo, usuario.Correo);
            Assert.AreEqual(contraseña, usuario.Clave);
        }
    }
}
