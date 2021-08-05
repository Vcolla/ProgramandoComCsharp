using System;

namespace Csharp.Capitulo01.ValeTransporte
{ 
    class Program
    {
        

        static void Main(string[] args)
        {
            Inicio;

            Console.WriteLine("Informe o Nome do Funcionario: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe o Salario do Funcionario: ");
            var salario =Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o gasto com transporte: ");
            var gastoTransporte  = Convert.ToDecimal(Console.ReadLine());

            var descontoMaximo = salario * 0.06m; //   6/100

            var descontoVT = gastoTransporte > descontoMaximo ? descontoMaximo : gastoTransporte;
            
            var resultado = $"\n Funcionário: {nome}" +
                $"\nSalário: {salario:c}" +
                $"\n Desconto VT: {descontoVT:c}";
            
            Console.WriteLine(resultado);
            Console.WriteLine("/n Pressione Enter para novo cálculo ou Esc para sair.");

            var comando = Console.ReadKey();

            if (comando.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);

            }
            Console.Clear();

            goto Inicio;
        }
    }
}
