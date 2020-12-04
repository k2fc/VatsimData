using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VatsimData;

namespace VatsimTest
{
    class Program
    {
        static void Main(string[] args)
        {
            VatsimData.VatsimData.GetData("https://data.vatsim.net/v3/vatsim-data.json");
            foreach (var item in VatsimData.VatsimData.Data.Pilots)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
