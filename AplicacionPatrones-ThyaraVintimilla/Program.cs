
using AplicacionPatrones_ThyaraVintimilla;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Clear();

        Figura cuartaFigura = Creadora.CreadoraFigura(Creadora.Cuadrado);
        Console.WriteLine(cuartaFigura.CuantasLadosTengo());

        Figura primeraFigura = Creadora.CreadoraFigura(Creadora.Circulo);
        Console.WriteLine(primeraFigura.CuantasLadosTengo());

        Figura segundaFigura = Creadora.CreadoraFigura(Creadora.Pentagono);
        Console.WriteLine(segundaFigura.CuantasLadosTengo());

        Figura terceraFigura = Creadora.CreadoraFigura(Creadora.Triangulo);
        Console.WriteLine(terceraFigura.CuantasLadosTengo());

      

        
    }
}
