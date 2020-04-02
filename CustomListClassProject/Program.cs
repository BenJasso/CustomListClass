using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ListB<int> listB = new ListB<int>();



            //act
            listB.Add(23);
            listB.Add(33);
            listB.Add(43);
            listB.Add(38);
            listB.Add(55);

            Console.WriteLine($"{listB[7]}");





        }
        
    }
}
