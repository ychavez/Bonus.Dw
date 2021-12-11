using System;
using System.Linq;

namespace Bonus.Dw
{
    public class ExpLambdaFunc
    {

        public static void Run()
        {
            var palabra = "aabccg";
            Console.WriteLine(PrimerNoRepetido(palabra));
          
            
            Console.WriteLine(PrimernoRepetidoLambda(MisFunciones.GetNoRepetido,palabra));
            Console.WriteLine(PrimernoRepetidoLambda(x=> x.FirstOrDefault(), palabra));
        }
        public static char PrimerNoRepetidoClassic(string palabra)
        {
            foreach (var c in palabra)
            {
                if (palabra.ToCharArray().Where(x => x == c).Count() == 1)
                    return c;
            }
            return ' ';
        }
        public static char PrimerNoRepetido(string palabra) 
            => MisFunciones.GetNoRepetido(palabra);

        public static char PrimernoRepetidoLambda(Func<string, char> validacion, string palabra)
            => validacion(palabra);


    }
    public  class MisFunciones
    {
        /// <summary>
        /// obtiene el primer caracter no repetido en una cadena
        /// </summary>
        public static readonly Func<string, char> GetNoRepetido = s => s.ToCharArray()
                                                                        .GroupBy(x => x)
                                                                        .Where(x => x.Count() == 1)
                                                                        .Select(x => x.Key)
                                                                        .FirstOrDefault();
    }
}
