using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    class ValidCodeCheck
    {

        public static void ExceptionWithMessage()
        {
            try
            {
                throw new ArgumentNullException("new exception", new Exception());
            }
            catch(Exception ex) when (ex.Message=="test")
            {
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
