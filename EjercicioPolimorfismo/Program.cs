

using EjercicioPolimorfismo;

Circulo circulo = new Circulo(10);
Rectangulo rectangulo = new Rectangulo(10 , 20);
Triangulo triangulo = new Triangulo( 11, 11 ,14);

Console.WriteLine("Figura: Circulo");
Console.WriteLine($"Area: {circulo.CalcularArea()}");
Console.WriteLine($"Perimetro: {circulo.CalcularPerimetro()}");

Console.WriteLine();

Console.WriteLine("Figura: Rectangulo");
Console.WriteLine($"Area: {rectangulo.CalcularArea()}");
Console.WriteLine($"Perimetro: {rectangulo.CalcularPerimetro()}");

Console.WriteLine();    

Console.WriteLine("Figura: Triangulo");
Console.WriteLine($"Area: {triangulo.CalcularArea()}");
Console.WriteLine($"Perimetro: {triangulo.CalcularPerimetro()}");

