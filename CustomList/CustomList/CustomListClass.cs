using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomListClass<T>: IEnumerable<T>
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
                if (i>count) {
                    throw new IndexOutOfRangeException();
                }
                else {

                    return array[i]; }
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
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {

                yield return array[i];

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
            bool correctSize = CheckCapacity(count, capacity);
            if (!correctSize)
            {
                T[] tempArray = new T[capacity * 2];
                capacity = capacity * 2;

                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = array[i];
                }
                array = tempArray;
            }
            array[count] = value;
            count++;
        }
        public void Remove(T value)
        {
            int index = Find(value);
            if (index >= 0 && index <= count){
                RemoveAt(index);
                count--;
                            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }                                            
                   
        }

        public void RemoveAt (int index)
        {
            for (int i= index; i < count; i++)
            {
                array[i] = array[i + 1];                
            }
        }

        public int Find(T value)
        {
            int index=-1;
            for (int i=0; i < count; i++)
            {
                if (array[i].Equals(value))
                {
                    index = i ;
                    return index;
                }
                
            }
            return index;

        }

        public static CustomListClass<T> operator+ (CustomListClass<T> list1, CustomListClass<T> list2 )
        {
            CustomListClass<T> array = new CustomListClass<T> ();      
            foreach (T item in list1)
            {
                array.Add(item);

            }
            foreach(T item in list2)
            {
                array.Add(item);
            }
            return array;


        }

        public static CustomListClass<T> operator -(CustomListClass<T> list1, CustomListClass<T> list2)
        {
            CustomListClass<T> array = new CustomListClass<T>();
            array = list1;
            foreach (T item in list2)
            {
                array.Remove(item);

            }
        
            return array;


        }
        
        public CustomListClass<T> Zipper(CustomListClass<T> list1, CustomListClass<T> list2)
        {
            CustomListClass<T> tempList = new CustomListClass<T>();
            for (int i = 0; i < list2.Count; i++)
            {
                tempList.Add(list1[i]);
                tempList.Add(list2[i]);
            }
            return tempList;
        }

        public override string ToString()
        {
            string newString = "";

            for(int i = 0; i < count; i ++)
            {
                newString += array[i];
            }

            return newString ;
        }

        public string ToString(string character)
        {
            string newString = "";

            for (int i = 0; i < count; i++)
            {
                newString += array[i] + character;
            }

            return newString;
        }
    }



}
