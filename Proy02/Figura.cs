using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Proy02
{
    public abstract class Figura
    {
        private string _nombre;
        private string _id;
        private string _tipo;
        private float _size;
        private string _lineColor;
        private string _filleColor;
        const string BLACK="#000000";
        const string WHITE="#FFFFFF";

            public Figura()// Constructor inicial, recomendado en blanco
            {
                _id = Guid.NewGuid().ToString();
            } 
            public Figura(string nombreFigura)// Constructor con una firma diferente
            {
                _id=Guid.NewGuid().ToString();
                _nombre = nombreFigura;
                _tipo = "";
                _lineColor = BLACK;
                _filleColor = WHITE;
                
            }
            public string Id {get {return _id;}} // Ojo se requiere set en caso de carga de un Json
            public string Nombre
            {
                get{ return _nombre; }
                set {_nombre =value; }
            }
            public string LineColor
            {
                get{ return _lineColor; }

                set 
                {
                string patron ="^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";
                Match m = Regex.Match(value,patron,RegexOptions.IgnoreCase);

                if(m.Success)
                    _lineColor=value;
                else
                  throw new ArgumentException("Color mal definido. Verifique");
                }
            }
             public float Size{ get => _size; set => _size = value; }
            
            public Figura(string nombreFigura, string tipoFigura, string colorLinea, string colorRelleno)// Constructor con una firma diferente
            {
                _id=Guid.NewGuid().ToString();
                _nombre = nombreFigura;
                _tipo = tipoFigura;
                _lineColor = colorLinea;
                _filleColor = colorRelleno;
            }
            public void dibujar(){ }

            public abstract float getSize();
            
           
    }
}