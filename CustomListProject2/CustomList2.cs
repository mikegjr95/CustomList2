using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject2
{
    public class CustomList2<T>
    {
        // member variables
        private int count;
        private int capacity;
        private T[] items;
        private int input;




        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        // constructor
        public CustomList2()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }


        // member methods
        public void Add(T item)
        {
            if (count != capacity){
                items[count] = item;
                count++;
            }
            else if (count == capacity)
            {
                capacity = capacity * 2;

                T[] temparray = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    temparray[i] = items[i];
                }

                items = new T[capacity];
                for (int a = 0; a < count; a++)
                {
                    items[a] = temparray[a];
                }

                items[count] = item;
                count++;
            }

        }

        public void Remove(T item)
        {
            T[] temparray = new T[count];
            int j = 0;
            int counter = 0;
            int countHolder = count;
            for (int i = 0; i < countHolder; i++)
            {
                if (items[i].Equals(item) && counter == 0)
                {
                    counter++;
                    count--;
                }
                else

                {
                    temparray[j] = items[i];
                    j++;
                }

            }

            items = new T[count];
            for (int k = 0; k < count; k++)
            {
                items[k] = temparray[k];
            }
        }
    }
}

