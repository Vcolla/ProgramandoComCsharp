using Csharp.Capitulo02.GeradorSenha;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Capitulo02.GeradorSenha.Tests
{
    [TestClass()]
    public class SenhaTests
    {
        //[TestMethod()]
        //public void GerarSenhaTest()
        //{
        //    Senha password = new Senha();
        //    password.Tamanho = 4;
        //    string novaSenha = password.GerarSenha();

        //    Assert.IsTrue(novaSenha.Length == 4);
        //}

        [TestMethod]
        public void ConstrutorPadraoDeveRetornarSenhaPadrao()
        {
            var senha = new Senha();

            Assert.IsTrue(senha.Password.Length == Senha.TamanhoMinimo);
            Assert.IsTrue(int.TryParse(senha.Password, out _));
        }

        [TestMethod]
        [DataRow(6)]
        [DataRow(3)]
        [DataRow(11)]
        public void ConstrutorParametrizadoDeveRetornarSenhaEspecifica(int tamanho)
        {
            var senha = new Senha();

            Assert.IsTrue(senha.Password.Length == senha.Tamanho);
            Assert.IsTrue(long.TryParse(senha.Password, out _));
            Assert.IsTrue(senha.Tamanho >= Senha.TamanhoMinimo);
            Assert.IsTrue(senha.Tamanho <= Senha.TamanhoMaximo);


        }
    }

}