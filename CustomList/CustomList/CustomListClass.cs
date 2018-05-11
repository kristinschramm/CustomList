using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomListClass<T>
    {
        T[] array;
        int count = 0;
        int capacity = 0;

        public CustomListClass()
        {

            array = new T[5];
            capacity += 5;

        }

        // + - operators above properties
        public T this[int i]

        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
            }
        }
        public int Count {
            get {
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
        public bool CheckCapacity(int count, int capacity)
        {
            if (count + 1 > capacity - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Add(T value)
        {
            bool trueFalse = CheckCapacity(count, capacity);
            if (trueFalse == true)
            {
                array[count] = value;
            }
            else
            {
                T[] tempArray = new T[capacity * 2];
                capacity = capacity * 2;
                array = tempArray;
                array[count] = value;


            }
            count++;
        }
        public void Remove(T value)
        {
            int index = Find(value);
            if (index>0 && index < count){
                RemoveAt(index);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }                                            
                   
        }

        public void RemoveAt (int index)
        {
            for (int i= index; i >count; i++)
            {
                array[i] = array[i + 1];
            }
        }

        public int Find(T value)
        {
            int index = -1;
            for (int i=0; i > count; i++)
            {
                if (array[i].Equals(value))
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }

    }
}
