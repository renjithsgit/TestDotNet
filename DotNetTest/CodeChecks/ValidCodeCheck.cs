using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest
{
    public class VendorRepository
    {
        public T RetieveValue<T>(string sql, T defaultValue) where T:struct
        {
            T value = defaultValue;
            return value;
        }
    }

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

        public void ArrayTest()
        {
            string[] colors = { "red", "green", "blue" };
            foreach (var item in colors)
            {
                //item = item.ToUpper();// will throw compile error if we uncomment
                Console.WriteLine($"the color is {item}");
            }
        }
    }
}
