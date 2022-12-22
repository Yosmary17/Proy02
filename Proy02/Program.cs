namespace Proy02
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Cuadrado  cuad = new Cuadrado();
            cuad.Lado = 10;
            cuad.Nombre="Mi cuadrado";
            cuad.LineColor= "#F00000";
            Console.WriteLine($"Nombre: {cuad.Nombre} ");
            Console.WriteLine($"ID: {cuad.Id} ");
            Console.WriteLine($"Lado: {cuad.Lado} ");
            Console.WriteLine($"Area: {cuad.getSize()} ");
            Console.WriteLine($"Perimetro: {cuad.getPerimetro()}");
        }
    }
}
