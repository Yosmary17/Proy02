using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proy02
{
    public class Cuadrado : Figura2D
    {
        private float _lado;
        public Cuadrado(){ }
        public Cuadrado(string nombre, float lado) :base(nombre)
        {
            _lado = lado;
        }

        public override float getPerimetro()
        {
            return _lado * _lado;
        }
    }
}