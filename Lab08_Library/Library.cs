using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab08_Library
{
    public class Library<T>
    {
        T[] books;
        int count;



        public int Count => count;
        public T this[int index] => books[index];

        public Library(int capacity)
        {
            books = new T[capacity];
        }
        public Library() : this(5)
        {

        }

        public void Add(T value)
        {
            if (books.Length == count)
            {
                Array.Resize(ref books, count*2);
            }
            books[count] = value;
            count++;
        }



    }
}
