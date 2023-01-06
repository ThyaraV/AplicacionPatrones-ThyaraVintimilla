using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPatrones_ThyaraVintimilla
{
    public class Creadora
    {
        public const int Circulo = 1;
        public const int Cuadrado = 2;
        public const int Triangulo = 3;
        public const int Pentagono = 4;

        public static Figura CreadoraFigura(int TipoFigura) // ClASE CREADORA DE LOS OBJETOS
        {
            switch (TipoFigura)
            {
                case Circulo:
                    return new Circulo();

                case Cuadrado:
                    return new Cuadrado();

                case Triangulo:
                    return new Triangulo();

                case Pentagono:
                    return new Pentagono();

                default:
                    return null;
            }
        }
    }
}
