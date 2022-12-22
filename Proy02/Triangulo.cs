using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proy02
{
    public class Triangulo : Figura2D
    {
        private float _lado1;
        private float _lado2;
        private float _lado3;
        private float _perimetro;
        public Triangulo(){}
        public Triangulo(string nombre, float lado1, float lado2, float _lado3) :base()
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _lado3 = _lado3;

        }

        public override float getPerimetro()
        {
            _perimetro = _lado1 + _lado2 + _lado3;
            return _perimetro;
        }
        public override float getSize()
        {
            float s =_perimetro/2;
            float temp = s *(s-_lado1)*(s-_lado2)*(s-_lado3);
            double Area =Math.Sqrt(temp); 
          //  this.Size =Convert.ToSingle(area);
        
            return this.Size;
        }
    
    }
}