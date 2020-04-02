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
            newlist.Add(1);
            newlist.Add(2);
            newlist.Add(3);


            Console.WriteLine(newlist.ToString());
            Console.ReadLine();






            Console.WriteLine(newlist.Count);
            Console.ReadLine();
            
        }
        
    }
}
