using System;

namespace imaginum
{
    class main
    {
        static int Menu(){
            int op;
            Console.WriteLine("----------Bem vindo a Imaginum----------");
            Console.WriteLine("---Calculadora de numeros imaginarios---");
            Console.WriteLine("> 1 - Adição ");
            Console.WriteLine("> 2 - Subtração");
            Console.WriteLine("> 3 - Multiplicação");
            Console.WriteLine("> 4 - Divisão");
            Console.WriteLine("> 5 - Módulo");
            Console.WriteLine("> 6 - Sair");

            Console.WriteLine(">>Escolha a opção desejada\nR:");
            op = int.Parse(Console.ReadLine());

            return op;
        }
        
        static void Main(string[] args)
        {
            
            try
            {
                int opcao = Menu();
                while (opcao != 6 )
                {
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
