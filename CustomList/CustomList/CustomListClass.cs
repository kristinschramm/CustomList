using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomListClass <T>
    {


        public void Add(T value)
        {
           T [] array = new T []{ value };
        }
    }

    
}
