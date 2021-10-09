using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imaginum
{
    class Calculadora{
        public static void Soma(Complexos nmr1, Complexos nmr2){//soma o nmr1 pelo nmr2
            double somareal = nmr1.real + nmr2.real;
            double somaimag = nmr1.imaginario + nmr2.imaginario;

            if (somaimag > 0){
                Console.WriteLine("A soma dos numeros complexos é: " + somareal + "+" + somaimag + "i");
            }else{
                Console.WriteLine("A soma dos numeros complexos é: " + somareal + "-" + somaimag + "i");
            }
        }

        public static void Subtracao(Complexos nmr1, Complexos nmr2)//subtrai o nmr1 pelo nmr2
        {
            Complexos sub = new Complexos(nmr1.real - nmr2.real, nmr1.imaginario - nmr2.imaginario);
            
            //if (sub.imaginario > 0){
                Console.WriteLine("A subtracao dos numeros complexos é: " + sub.ImprimeImaginario() );
            //}else{
                Console.WriteLine("A subtracao dos numeros complexos é: " + sub.ImprimeImaginario() );
           //}
        }

        public static void Multiplicacao(Complexos nmr1, Complexos nmr2)//multiplica o nmr1 pelo nmr2
        {
            Complexos produto = new();

            produto.SetImag( ( (nmr1.real * nmr2.real) - (nmr1.imaginario * nmr2.imaginario) ), ( (nmr1.real * nmr2.imaginario) + (nmr1.imaginario * nmr2.real) ) );

            if (produto.imaginario > 0){
                Console.WriteLine("O produto dos numeros complexos é: " + produto.real + "+" + produto.imaginario + "i");
            }else{
                Console.WriteLine("O produto dos numeros complexos é: " + produto.real + "-" + produto.imaginario + "i");
            }

        }
        public static void Divisao(Complexos nmr1, Complexos nmr2)//divide o nmr1 pelo nmr2
        {
            Complexos divisao = new Complexos(((nmr1.real * nmr2.real) + (nmr1.imaginario * -nmr2.imaginario)) / (Math.Pow(nmr2.real, 2.0) + Math.Pow(-nmr2.imaginario, 2.0)),
                                                ((nmr1.imaginario * nmr2.real) - (nmr1.real * -nmr2.imaginario)) / (Math.Pow(nmr2.real, 2.0) + Math.Pow(-nmr2.imaginario, 2.0)));

            if (divisao.imaginario > 0){
                Console.WriteLine("A divisao entre os numeros complexos é: " + divisao.real + "+" + divisao.imaginario + "i");
            }else{
                Console.WriteLine("A divisao entre os numeros complexos é: " + divisao.real + "-" + divisao.imaginario + "i");
            }
        }

        public static void Modulo(Complexos nmr1, Complexos nmr2)//retorna o modulo de cada numero complexo
        {
            Console.WriteLine("O modulo de " + nmr1.ImprimeImaginario() + "é " + nmr1.Modulo_Img() ); 
            Console.WriteLine("O modulo de " + nmr2.ImprimeImaginario() + "é " + nmr2.Modulo_Img() );
        }
    }
}
