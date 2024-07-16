using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Class1
    {
        public string GetGeneral(int i)
        {
            Console.WriteLine(i.ToString() + " 2 method");
            return i.ToString();
        }

        public void Write(string name)
        {
            Console.WriteLine(name);
        }
    }
}
