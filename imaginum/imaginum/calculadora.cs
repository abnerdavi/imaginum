using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imaginum
{
    class calculadora{
        public static void Soma(Complexos nmr1, Complexos nmr2){
            double somareal = nmr1.real + nmr2.real;
            double somaimag = nmr1.imaginario + nmr2.imaginario;

            if (somaimag > 0){
                Console.WriteLine("A soma dos numeros complexos é: " + somareal + "+" + somaimag + "i");
            }else{
                Console.WriteLine("A soma dos numeros complexos é: " + somareal + "-" + somaimag + "i");
            }
        }

        public static void Subtracao(Complexos nmr1, Complexos nmr2)
        {
            double somareal = nmr1.real - nmr2.real;
            double somaimag = nmr1.imaginario - nmr2.imaginario;
            
            if (somaimag > 0){
                Console.WriteLine("A subtracao dos numeros complexos é: " + somareal + "+" + somaimag + "i");
            }else{
                Console.WriteLine("A subtracao dos numeros complexos é: " + somareal + "-" + somaimag + "i");
            }
        }

        public static void Multiplicacao(Complexos nmr1, Complexos nmr2)
        {
            Complexos produto = new();

            produto.SetImag( ( (nmr1.real * nmr2.real) - (nmr1.imaginario * nmr2.imaginario) ), ( (nmr1.real * nmr2.imaginario) + (nmr1.imaginario * nmr2.real) ) );

            if (produto.imaginario > 0){
                Console.WriteLine("O produto dos numeros complexos é: " + produto.real + "+" + produto.imaginario + "i");
            }else{
                Console.WriteLine("O produto dos numeros complexos é: " + produto.real + "-" + produto.imaginario + "i");
            }

        }public static void Divisao(Complexos nmr1, Complexos nmr2)
        {
            Complexos produto = new();

            double real = ( (nmr1.real * nmr2.real) + (nmr1.imaginario * -nmr2.imaginario) ) / ( Math.Pow(nmr2.real,2.0)+Math.Pow(-nmr2.imaginario,2.0) );
            double imaginaria = ( (nmr1.imaginario * nmr2.real) - (nmr1.real * -nmr2.imaginario) ) / ( Math.Pow(nmr2.real, 2.0) + Math.Pow(-nmr2.imaginario,2.0) );

            produto.SetImag( real, imaginaria);

            if (produto.imaginario > 0){
                Console.WriteLine("A divisao entre os numeros complexos é: " + produto.real + "+" + produto.imaginario + "i");
            }else{
                Console.WriteLine("A divisao entre os numeros complexos é: " + produto.real + "-" + produto.imaginario + "i");
            }
        }

    }
}
