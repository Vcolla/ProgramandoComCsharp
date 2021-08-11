using System;

namespace Csharp.Capitulo02.GeradorSenha
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.Write(" Informe a quantidade par de dígitos da senha( entre 4 e 10): ");

             var quantidadeDigitos = 0;
             while (quantidadeDigitos == 0)
             {
                 quantidadeDigitos = ObterQuantidadeDigitos() ;

             }*/
            int quantidadeDigitos;
            do
            {
                Console.WriteLine("###################################################################");
                Console.Write(" Informe a quantidade par de dígitos da senha( entre 4 e 10): ");
               
                quantidadeDigitos = ObterQuantidadeDigitos();

            } while (quantidadeDigitos == 0);

            //var senha = string.Empty; //"";
            //var randomico = new Random();

            //for (int i = 0; i < quantidadeDigitos; i++)
            //{
            //    var digito = randomico.Next(10);
            //    senha += digito/*.ToString()*/;

            //}

            var senha = new Senha();
            Console.WriteLine($"Senha gerada: {senha.Password}");
            Environment.Exit(0);
        }

        private static int ObterQuantidadeDigitos()
         {
            int.TryParse(Console.ReadLine(), out int quantidadeDigitos);    

           
            if (quantidadeDigitos is < 4 or > 10 || quantidadeDigitos % 2 != 0)
            {
                Console.WriteLine($"A quantidade de digitos{quantidadeDigitos} é inválida de acordo com as regras. ");
                quantidadeDigitos = 0;
            }
            return quantidadeDigitos;
         }
      }
 }


   

