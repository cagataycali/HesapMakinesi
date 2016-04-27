using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _14253019HW1
{
    class ExtractInput

    {
        /**
        * Extract to integer from string object.
        */
        public int extractInput(string sayi)
        {
            /**
            * Default
            */
            int yanit = 0;

            /**
            * Stringimizin içerisinden integer değerleri ayıklayalım.
            */
            string resultString = Regex.Match(sayi, @"\d+").Value;

            /**
            * Call input validation
            */
            InputValidation inputValidate = new InputValidation();

            /**
            * Eğer gelen gerçekten integer ise
            */
            if (inputValidate.TryToInt32(resultString) == 1)
            {
                yanit = Int32.Parse(resultString);
            }

            // Return.
            return yanit;
        }
    }
}
