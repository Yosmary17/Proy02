namespace Proy02
{
    internal class Program
    {
        private static void Main(string[] args)
        {

           /*  Cuadrado  cuad = new Cuadrado();
            cuad.Lado = 10;
            cuad.Nombre="Mi cuadrado";
            cuad.LineColor= "#F00000";
            Console.WriteLine($"Nombre: {cuad.Nombre} ");
            Console.WriteLine($"ID: {cuad.Id} ");
            Console.WriteLine($"Lado: {cuad.Lado} ");
            Console.WriteLine($"Area: {cuad.getSize()} ");
            Console.WriteLine($"Perimetro: {cuad.getPerimetro()}");*/
       
            Triangulo tri= new Triangulo();
            tri.Nombre =" Mi triangulo";
            tri.Lado1 = 5;
            tri.Lado2 = 6;
            tri.Lado3 = 7;
            Console.WriteLine($"Nombre: {tri.Nombre} ");
            Console.WriteLine($"ID: {tri.Id} ");
            Console.WriteLine($"Lado 1: {tri.Lado1} ");
            Console.WriteLine($"Lado 2: {tri.Lado2} ");
            Console.WriteLine($"Lado 3: {tri.Lado3} ");
            Console.WriteLine($"Perimetro: {tri.getPerimetro()}");
            Console.WriteLine($"Area: {tri.getSize()} ");
        } 

    }
}
