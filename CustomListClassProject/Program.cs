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
            ListB<string> listB = new ListB<string>();
            ListB<string> listA = new ListB<string>();
            ListB<string> combinedList = new ListB<string>();
            

            //act
            listB.Add("B");
            listB.Add("e");
            listB.Add("n");
            listA.Add("B");
            listA.Add("a");
            listA.Add("m");
            listA.Add("i");
            listA.Add("n");

            combinedList = listB - listA;

            Console.WriteLine($"{combinedList.Count}");




            
        }
        
    }
}
