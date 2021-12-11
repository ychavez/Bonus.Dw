using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus.Dw
{
    public class Descontructores
    {

        public static void Run() 
        {
            var coordenadas = new Coordenadas(12,13);

            int latitud = coordenadas.X;
            int longitud = coordenadas.Y;

            var (x, y) = coordenadas;

            Console.WriteLine($"{latitud} {longitud}");

            Console.WriteLine($"{x} {y}");

        }

    }

    public class Coordenadas 
    {
        public int X = 1, Y = 2;
        public Coordenadas(int x,int y)
        {
            X = x; Y = y;
        }

        public void Deconstruct(out string x, out string y)
        {
            x = X.ToString();
            y = Y.ToString();
        }

    }
}
