using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08_Library
{
   
    public class Books
    {
        public string Title { get; }
        public  Genre Genre { get; set; }
       
    }
    public enum Genre { 
        Fantacy,
        Science,
        History, 
        Geography
    }
}
