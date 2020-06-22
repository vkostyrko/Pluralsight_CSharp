using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Interactive
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                   
                }
                catch (Exception e)
                {

                    throw;
                }
                finally
                {
                    Console.WriteLine("Method 2");
                }
                
            }
            catch (Exception e)
            {

                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                   
                }
            }
            finally
            {
                Console.WriteLine("Method 1");
            }
            Console.ReadKey();
        }

        

    }
}
