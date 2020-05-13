using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Lab08_Library
{
    public class Library<T> : IEnumerable<T>
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
        public void Remove( T book)
        {

            for (int i = 0; i < count; i++)
            {
                
                if (IsAvailable(book))
                {
                    for (int j = 0; j < count-i; j++)
                    {
                        books[i] = books[i+1];
                        i++;
                    }
                }
                
            }
            count--;
           
        }

        public override string ToString()
        {
            string result = "";
            for(int i=0; i<count; i++)
            {
                result+= $"{{{books[i]}}}->";

            }
            return result;
           
        }
        public bool IsAvailable(T value)
        {
            for (int i = 0 ; i<count ; i++)
            {
                if (books[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i= 0; i < count ; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
