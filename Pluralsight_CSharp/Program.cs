using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pluralsight_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.ReadKey();
        }
    }
    public class TestDto
    {
        public string Page { get; set; }

        public int Language { get; set; }
    }
}
