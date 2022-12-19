using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proy02
{
    public abstract class Figura2D : Figura
    {
        private float _perimetro;
        public Figura2D(){}
        public Figura2D(string nombreFigura) : base(){}
        public Figura2D(string nombreFigura, string tipoFigura, string colorLinea, string colorRelleno) :base(){}
        
        public abstract float  getPerimetro();
    }
}