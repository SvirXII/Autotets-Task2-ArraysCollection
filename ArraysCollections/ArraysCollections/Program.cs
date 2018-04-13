using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "Alex", "Dima", "Kate", "Galina", "Ivan" };
            string[] arr2 = { "Dima", "Ivan", "Kate" };
            string[] arr3 = arr1.Except<string>(arr2).ToArray<string>();
            foreach (string name in arr3)
            {
                Console.WriteLine(name);
            }
                
        }
    }
}
