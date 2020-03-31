using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class ListB<T>
    {
        //member variables
        int count;
        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }
        int capacity;
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        private T[] listArray;
        public T this[int number]
        {
            get
            {

                return listArray[number];


            }
            set
            {

                listArray[number] = value;

            }
        }
        private T[] tempArray;
        


        //constructor
        public ListB()
        {
            capacity = 4;
            listArray = new T[capacity];
           
        }

        //member methods
        public void Add(T value)
        {   
            if(count < capacity)
            {
                listArray[count] = value;
                count++;
            }

            
            else if (count >= capacity)
            {
                
                capacity *= 2;
                tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = listArray[i];
                    
                }
                listArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    listArray[i] = tempArray[i];
                }
                
                
                listArray[count] = value;
                count++;

            }
            
            
            

           
        }

    }
}
