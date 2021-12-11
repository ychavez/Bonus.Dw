using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus.Dw
{
   public class FuncionesLocales
    {
        public static void Run() 
        {

            Console.WriteLine(Potenciar(4,4));
        
        }

     

        public static int Potenciar(int numero, int potencia)
        {

            int resultado = numero;

            for (int i = 0; i < potencia -1; i++)
            {
                resultado = multiplicar(numero);
            }

            var hola = multiplicar(10);
            
            return resultado;

            int multiplicar(int _numero)
            {
                return _numero * resultado;
            }
        }

    }
}
