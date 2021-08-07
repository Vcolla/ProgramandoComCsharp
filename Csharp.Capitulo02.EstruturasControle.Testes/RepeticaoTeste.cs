using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Csharp.Capitulo02.EstruturasControle.Testes
{
    [TestClass]
    public class RepeticaoTeste

    {
        [TestMethod]
        public void TabuadaTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int a = 1; a <= 10; a++)
                {
                    Console.WriteLine($"{i}* {a} = {i * a}");
                }
                Console.WriteLine(new string('-', 50));
            }

        }
        [TestMethod]
        public void EstruturaForTeste()
        {
            var i = 1;
            for (Console.WriteLine("Iniciou"); i <= 3; Console.WriteLine(i++))
            {


            }
            /*
             for(1.Inicialização; 2.Condição; 4.Pós-execução)
            {
                3.Execução
            }
             */

        }
        [TestMethod]
        public void ForApenasComCondicaoTeste()
        {
            var i = 1;
            for (; ++i <= 3;)
            {
                Console.WriteLine(i);
            }
        }
        public void ContinueTeste()
        {

            for (int i = 1; i <= 10; i++)
            {

                if (i <= 5)
                {
                    continue;
                }

                Console.WriteLine(i);

            }

        }

        public void BreakTest()
        {

            for (int i = 1; i <= 10; i++)
            {

                if (i > 5)
                {
                    break;
                }

                Console.WriteLine(i);

            }
        }
    }

}
