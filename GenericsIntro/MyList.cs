using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }

        //thing
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            //sırayla tempArray'e verdiği değerleri sırayla for ile tekrar üzerine alıyor.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
