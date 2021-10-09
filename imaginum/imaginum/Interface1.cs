using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imaginum
{
    interface Interface1
    {

        public void SetImag(double rl, double img);
        public double Modulo_Img();
        public string ImprimeImaginario();
        public void Soma(Complexos nmr1, Complexos nmr2);
        public void Divisao(Complexos nmr1, Complexos nmr2);
        public void Multiplicacao(Complexos nmr1, Complexos nmr2);
        public void Subtracao(Complexos nmr1, Complexos nmr2);
        public void Modulo(Complexos nmr1, Complexos nmr2);

    }
}
