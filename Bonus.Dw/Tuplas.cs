using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus.Dw
{
   public class Tuplas
    {

        public static (int numero1, int numero2) tuplas(int a, int b) 
        {
            return (12*a, 14*b);
        }

        public static void Run() 
        {
            var resultado = tuplas(6, 2);
          //  Console.WriteLine($"{resultado.numero1} {resultado.numero2}");
            
            (int num1, int num2) = tuplas(34, 56);

          //  Console.WriteLine($"{num1} {num2}");


            var miFuncion = new Func<int, int, (int suma, int multiplicacion)>((x, y) => (x + y, x * y));

            var lambdaResultTupla = miFuncion(12, 14);

            Console.WriteLine($"el resultado de la suma es{lambdaResultTupla.suma} " +
                $"y la multuplicacion {lambdaResultTupla.multiplicacion} ");


            var yo = (Nombre: "Yael", Edad: 29);

            Console.WriteLine(yo);

        }


        static Tuple<int, int> sumarmultplicar_Old(int suma, int mult) 
        {
            return Tuple.Create(suma + suma, mult + mult);
        }

    }
}
