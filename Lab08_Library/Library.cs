using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab08_Library
{
    public class Library<T>
    {
        T[] books;
        int count;



        public int Count => count;

        public Library(int capacity)
        {
            books = new T[capacity];
        }
        public Library() : this(5)
        {

        }

    }
}
