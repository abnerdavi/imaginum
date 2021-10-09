using System;

namespace imaginum
{
    class main
    {
        static int Menu(){
            int op;
            Console.WriteLine("----------Bem vindo a Imaginum----------");
            Console.WriteLine("---Calculadora de numeros imaginarios---");
            Console.WriteLine(">    1 - Adição ");
            Console.WriteLine(">    2 - Subtração");
            Console.WriteLine(">    3 - Multiplicação");
            Console.WriteLine(">    4 - Divisão");
            Console.WriteLine(">    5 - Módulo");
            Console.WriteLine(">    6 - Sair");
            Console.Write(">> Escolha a opção desejada: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        
        static void LeNumeros(ref Complexos n1, ref Complexos n2){
            double x, y;

            Console.WriteLine("Informe a parte real do primeiro numero: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a parte imaginaria do primeiro numero: ");
            y = double.Parse(Console.ReadLine());
            n1.SetImag(x,y);

            Console.WriteLine("Informe a parte real do segundo numero: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a parte imaginaria do segundo numero: ");
            y = double.Parse(Console.ReadLine());
            n2.SetImag(x, y);           
        }
        static void Main(string[] args)
        {
            int opcao = 0;
            Complexos numero1 = new Complexos();
            Complexos numero2 = new Complexos();
            
            try{
                while (opcao != 6 ){
                    opcao = Menu();
                    switch (opcao){
                        case 1:
                            LeNumeros(ref numero1, ref numero2);
                            Calculadora.Soma(numero1, numero2);
                            break;

                        case 2:
                            LeNumeros(ref numero1, ref numero2);
                            Calculadora.Subtracao(numero1, numero2);
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            break;

                        case 6:
                            Console.WriteLine("Obrigado por usar a calculadora Imaginum!");
                            break;

                        default:
                           break;
                    }
                    Console.WriteLine("Digite qualquer tecla para continuar...");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
