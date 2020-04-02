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
            ListB<int> listA = new ListB<int>();
            ListB<int> zippedList = new ListB<int>();
           

            //act
            listB.Add(1);
            listB.Add(2);
            listB.Add(3);
            listB.Add(5);
            listA.Add(1);
            listA.Add(4);
            listA.Add(5);
            listA.Add(6);
            listA.Add(7);

            zippedList = listB.Zip(listA);



            Console.WriteLine($"{zippedList.Count}");
            Console.ReadLine();





        }
        
    }
}
