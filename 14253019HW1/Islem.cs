using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253019HW1
{
    class Islem
    {
        /**
       Let's do this marines!
       */
        public float islemYap(int sayi1, int sayi2, string islem)
        {
            float yanit = 0;

            switch (islem)
            {
                case "+":
                    yanit = sayi1 + sayi2;
                    break;
                case "-":
                    yanit = sayi1 - sayi2;
                    break;
                case "*":
                    yanit = sayi1 * sayi2;
                    break;
                case "/":
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("Matematik kurallarına aykırı bir payda girdiniz.");
                        yanit = 0;
                        break;
                    }
                    yanit = (float)sayi1 / (float)sayi2;
                    break;
                default:
                    yanit = 0;
                    break;
            }

            return yanit;
        }
    }
}
