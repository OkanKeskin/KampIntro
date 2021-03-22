﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionart
{
    class MyDictionary<T>
    {
        T[] items;
        public MyDictionary()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempItems = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }

            items[items.Length - 1] = item;
        }

        public int Count
        {
            get { return items.Length; }
        }

        public void Listing()
        {
              foreach (var item in items)
              {
                Console.WriteLine("Ürün adı : {0}", item);
              } 
        }

    }
            
    
}