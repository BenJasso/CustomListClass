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
            ListB<int> newlist = new ListB<int>();
            newlist.Add(32);
            
            Console.WriteLine(newlist[0]);
            Console.ReadLine();
            
        }
        
    }
}
