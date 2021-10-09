using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imaginum{
    class Complexos: Interface1
    {
        public double real { get; private set; }
        public double imaginario { get; private set; }

        public Complexos() {}
        public Complexos(double _real, double _imaginario){
            real = _real;
            imaginario =_imaginario;
        }

        public void SetImag(double rl, double img){
            real = rl;
            imaginario = img;
        }
        
        public double Modulo_Img(){
            double h = Math.Sqrt( (Math.Pow(real,2.0) + Math.Pow(imaginario,2.0)) ) ;
            return h;
        }

        public string ImprimeImaginario(){
            if (imaginario >= 0){
                return (real + "+" + imaginario + "i");
            }else{
                return (real + "" + imaginario + "i");
            }
        }

        public void Soma(Complexos nmr1, Complexos nmr2)
        {//soma o nmr1 pelo nmr2
            Complexos sm = new Complexos( nmr1.real + nmr2.real, nmr1.imaginario + nmr2.imaginario);
            Console.WriteLine("\nA soma dos numeros complexos é: " + sm.ImprimeImaginario());
        }

        public void Subtracao(Complexos nmr1, Complexos nmr2)
        {//subtrai o nmr1 pelo nmr2
            Complexos sub = new Complexos(nmr1.real - nmr2.real, nmr1.imaginario - nmr2.imaginario);
            Console.WriteLine("\nA subtracao dos numeros complexos é: " + sub.ImprimeImaginario());
        }

        public void Multiplicacao(Complexos nmr1, Complexos nmr2)
        {//multiplica o nmr1 pelo nmr2
            Complexos produto = new Complexos(((nmr1.real * nmr2.real) - (nmr1.imaginario * nmr2.imaginario)), ((nmr1.real * nmr2.imaginario) + (nmr1.imaginario * nmr2.real)));
            Console.WriteLine("\nO produto dos numeros complexos é: " + produto.ImprimeImaginario());
        }

        public void Divisao(Complexos nmr1, Complexos nmr2)
        {//divide o nmr1 pelo nmr2
            Complexos divisao = new Complexos(((nmr1.real * nmr2.real) + (nmr1.imaginario * nmr2.imaginario)) / (Math.Pow(nmr2.real, 2.0) + Math.Pow(nmr2.imaginario, 2.0)),
                                                ((nmr1.imaginario * nmr2.real) - (nmr1.real * nmr2.imaginario)) / (Math.Pow(nmr2.real, 2.0) + Math.Pow(nmr2.imaginario, 2.0)));

            Console.WriteLine("\nA divisao dos numeros complexos é: " + divisao.ImprimeImaginario());
        }
        
        public void Modulo(Complexos nmr1, Complexos nmr2)
        {//retorna o modulo de cada numero complexo
            Console.WriteLine("\nO modulo de " + nmr1.ImprimeImaginario() + " é " + nmr1.Modulo_Img());
            Console.WriteLine("O modulo de " + nmr2.ImprimeImaginario() + " é " + nmr2.Modulo_Img());
        }
    }
}
