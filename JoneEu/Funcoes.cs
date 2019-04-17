using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoneEu
{
   public class Funcoes
    {
        public static int trataInt(object Values, int Default = 0)
        {
            try
            {

                return Convert.ToInt32(Values);
            }
            catch 
            {

                return Default;
            }
        }
        
        public static string trataString(object Values, string Default = "")
        {
            try
            {
                return Convert.ToString(Values);

            }
            catch 
            {

                return Default;
            }
        }

        public static double trataDouble(object Values, double Default = 0)
        {
            try
            {
                return Convert.ToDouble(Values);
            }
            catch 
            {

                return Default;
            }
        }
    }
}
