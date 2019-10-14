using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            God myGod = God.GetInstance("I am the true god");
            God falseGod = God.GetInstance("No! *I* am the true god!");

            Console.WriteLine(myGod.getGodSays());
        }
    }
}
