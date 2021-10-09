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
            Console.Write(">> Digite o numero da opção desejada: ");
            while(!(int.TryParse(Console.ReadLine(),out op))){Console.Write(">> Digite o numero da opção desejada: ");}      
            return op;
            
        }
        
        static void LeNumeros(ref Interface1 n1, ref Interface1 n2){
            double x, y;

            Console.Write("\nInforme a parte real do primeiro numero: ");
            //x = double.Parse(Console.ReadLine());
            while (!(double.TryParse(Console.ReadLine(),out x))){Console.Write("\nInforme a parte real do primeiro numero: ");}

            Console.Write("Informe a parte imaginaria do primeiro numero: ");
            //y = double.Parse(Console.ReadLine());
            while (!(double.TryParse(Console.ReadLine(), out y))) { Console.Write("\nInforme a parte imaginaria do primeiro numero: "); }
            n1.SetImag(x,y);
            Console.WriteLine(">>"+n1.ImprimeImaginario());
            
            
            Console.Write("\nInforme a parte real do segundo numero: ");
            //x = double.Parse(Console.ReadLine());
            while (!(double.TryParse(Console.ReadLine(), out x))) { Console.Write("\nInforme a parte real do segundo numero: "); }
            Console.Write("Informe a parte imaginaria do segundo numero: ");
            //y = double.Parse(Console.ReadLine());
            while (!(double.TryParse(Console.ReadLine(), out y))) { Console.Write("\nInforme a parte imaginaria do segundo numero: "); }
            n2.SetImag(x, y);
            Console.WriteLine(">>"+n2.ImprimeImaginario());
                       
        }
        static void Main()
        {
            int opcao = 0;
            Interface1 numero1 = new Complexos();
            Interface1 numero2 = new Complexos();
            Interface1 Calculadora = new Complexos();

            
                while (opcao != 6 ){
                    opcao = Menu();
                    switch (opcao){
                        case 1:
                            LeNumeros(ref numero1, ref numero2);
                            Calculadora.Soma((Complexos)numero1, (Complexos)numero2);
                            break;

                        case 2:
                            LeNumeros(ref numero1, ref numero2);
                            Calculadora.Subtracao((Complexos)numero1, (Complexos)numero2);
                            break;

                        case 3:
                            LeNumeros(ref numero1, ref numero2);
                            Calculadora.Multiplicacao((Complexos)numero1,(Complexos)numero2);
                            break;

                        case 4:
                            LeNumeros(ref numero1, ref numero2);
                            Calculadora.Divisao((Complexos)numero1,(Complexos)numero2);
                            break;

                        case 5:
                            LeNumeros(ref numero1, ref numero2);
                            Calculadora.Modulo((Complexos)numero1,(Complexos)numero2);
                            break;

                        case 6:
                            Console.WriteLine("Obrigado por usar a calculadora Imaginum!");
                            break;

                        default:
                            Console.WriteLine("Opção inválida, tente novamente!");
                            break;
                    }
                    Console.WriteLine("\nDigite qualquer tecla para continuar...");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            
                
        }
    }
}
