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

            ListB<int> newlist2 = new ListB<int>();
            newlist2.Add(7);
            newlist2.Add(8);
            newlist2.Add(9);

            ListB<int> combinedList = new ListB<int>();
            combinedList = newlist + newlist2;
            Console.WriteLine(combinedList.ToString());
            Console.ReadLine();






            Console.WriteLine(newlist.Count);
            Console.ReadLine();
            
        }
        
    }
}
