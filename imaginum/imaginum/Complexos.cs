using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imaginum
{
    class Complexos
    {
       public double real { get; private set; }
       public double imaginario { get; private set; }

       public Complexos() {}
       public Complexos(double _real, double _imaginario)
       {
           real = _real;
           imaginario =_imaginario;
       }

    }
}
