using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab08_Library
{
    public class BookBag<T>
    {
        T[] bookbag;
        int count;

        public int Count => count;
        public T this[int index] => bookbag[index];
        public BookBag(int capacity)
        {
            bookbag = new T[capacity];
        }
        public BookBag() : this(5)
        {

        }
        public void Add(T value)
        {
            if (bookbag.Length == count)
            {
                Array.Resize(ref bookbag, count * 2);
            }
            bookbag[count] = value;
            count++;
        }
    }
}
