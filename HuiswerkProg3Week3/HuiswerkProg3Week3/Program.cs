using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuiswerkProg3Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> getallen = new MyList<int>(0);
            getallen.Add(2);
            getallen.Add(42);
            Console.WriteLine(getallen.Count());
            Console.WriteLine(getallen.ItemAt(1));
            Console.ReadKey();
        }
    }
}
