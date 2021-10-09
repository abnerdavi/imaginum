using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//sites que usei para as fórmulas, pois não lembrava de todas:
//  https://brasilescola.uol.com.br/matematica/numeros-complexos.htm   
//  https://matematicabasica.net/numeros-complexos/
//  https://www.todamateria.com.br/numeros-complexos/ 

namespace imaginum
{
    class Calculadora{
        public static void Soma(Complexos nmr1, Complexos nmr2){//soma o nmr1 pelo nmr2
            Complexos sm = new Complexos(nmr1.real + nmr2.real, nmr1.imaginario + nmr2.imaginario);
            Console.WriteLine("A soma dos numeros complexos é: " + sm.ImprimeImaginario());
        }

        public static void Subtracao(Complexos nmr1, Complexos nmr2){//subtrai o nmr1 pelo nmr2
            Complexos sub = new Complexos(nmr1.real - nmr2.real, nmr1.imaginario - nmr2.imaginario);
            Console.WriteLine("A subtracao dos numeros complexos é: " + sub.ImprimeImaginario() );
        }

        public static void Multiplicacao(Complexos nmr1, Complexos nmr2){//multiplica o nmr1 pelo nmr2
            Complexos produto = new Complexos( ( (nmr1.real * nmr2.real) - (nmr1.imaginario * nmr2.imaginario) ), ( (nmr1.real * nmr2.imaginario) + (nmr1.imaginario * nmr2.real) ) );
            Console.WriteLine("O produto dos numeros complexos é: " + produto.ImprimeImaginario());
        }

        public static void Divisao(Complexos nmr1, Complexos nmr2){//divide o nmr1 pelo nmr2
            Complexos divisao = new Complexos(((nmr1.real * nmr2.real) + (nmr1.imaginario * -nmr2.imaginario)) / (Math.Pow(nmr2.real, 2.0) + Math.Pow(-nmr2.imaginario, 2.0)),
                                                ((nmr1.imaginario * nmr2.real) - (nmr1.real * -nmr2.imaginario)) / (Math.Pow(nmr2.real, 2.0) + Math.Pow(-nmr2.imaginario, 2.0)));

            Console.WriteLine("A divisao dos numeros complexos é: " + divisao.ImprimeImaginario());
        }

        public static void Modulo(Complexos nmr1, Complexos nmr2){//retorna o modulo de cada numero complexo
            Console.WriteLine("O modulo de " + nmr1.ImprimeImaginario() + "é " + nmr1.Modulo_Img() ); 
            Console.WriteLine("O modulo de " + nmr2.ImprimeImaginario() + "é " + nmr2.Modulo_Img() );
        }
    }
}
