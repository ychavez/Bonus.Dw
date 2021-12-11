using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus.Dw
{
   public class YieldReturnEx
    {

        public static void Run() 
        {
            List<int> numerosRandom = llenarRandom(5).ToList();
        
        }

        public static IEnumerable<int> llenarRandom(int cuenta) 
        {
            for (int i = 0; i < cuenta; i++)
            {
               yield return new Random().Next();
            }

        }

    }
}
