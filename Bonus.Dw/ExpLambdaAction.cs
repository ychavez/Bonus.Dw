using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus.Dw
{

    public  class ExpLambdaAction
    {

        private static void ImprimirMesaje(Action<string,int> mensaje)
            => mensaje("esto fue un",1);

        public static void EvaluarNumeroAction(int numero)
            => ImprimirMesaje((s, y) =>  Console.WriteLine($"{s} numero grande."));

        public static void saludosMax()
            => ImprimirMesaje((s,y) => Console.WriteLine($"{s} Hola Max"));



        public static void EvaluarNumero(int numero)
        {
            if (numero > 10)
                Console.WriteLine($"El numero {numero} es un numero grande");
            else 
                Console.WriteLine($"El numero {numero} es un numero Pequeño");
        }
    }
}
