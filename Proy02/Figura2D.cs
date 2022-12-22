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
        public Figura2D(string nombreFigura) : base(nombreFigura){}
        public Figura2D(string nombreFigura, string tipoFigura, string colorLinea, string colorRelleno) :base(nombreFigura,tipoFigura,colorLinea,colorRelleno){}
        
        public abstract float  getPerimetro();
    }
}