using System;
using System.Collections.Generic;
using Xunit;

namespace Lab08_Library.Tests
{
    public class LibraryTests
    {
        [Fact]
        public void Initial_list_is_empty()
        {
            // Arrange

            // Act
            Library<string> myList = new Library<string>();

            // Assert
            Assert.Equal(0, myList.Count);
        }

        [Fact]
        public void Add_to_emptyList()
        {
            // Arrange
            Library<int> myList = new Library<int>();
            // Act
            myList.Add(4);

            // Assert
            Assert.Equal(1, myList.Count);
        }
        [Fact]
        public void Add_to_List()
        {
            // Arrange
            Library<int> myList = new Library<int>();
            myList.Add(4);
            myList.Add(1);
            myList.Add(6);
            // Act
            myList.Add(2);

            // Assert
            Assert.Equal(4, myList.Count);
        }
        [Fact]
        public void can_add_over_capacity()
        {
            int capacity = 4;
            // Arrange
            Library<int> myList = new Library<int>(capacity);
          
            // Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);


            // Assert
            Assert.Equal(6, myList.Count);
        }
        [Fact]
        public void Initial_list_is_empty_bagbooks()
        {
            // Arrange

            // Act
            BookBag<string> myList = new BookBag<string>();

            // Assert
            Assert.Equal(0, myList.Count);
        }

        [Fact]
        public void Add_to_emptyList_bookbags()
        {
            // Arrange
            BookBag<int> myList = new BookBag<int>();
            // Act
            myList.Add(4);

            // Assert
            Assert.Equal(1, myList.Count);
        }
        [Fact]
        public void Add_to_List_bookbag()
        {
            // Arrange
            BookBag<int> myList = new BookBag<int>();
            myList.Add(4);
            myList.Add(1);
            myList.Add(6);
            // Act
            myList.Add(2);

            // Assert
            Assert.Equal(4, myList.Count);
        }
        [Fact]
        public void can_add_over_capacity_bookbags()
        {
            int capacity = 4;
            // Arrange
            BookBag<int> myList = new BookBag<int>(capacity);

            // Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);


            // Assert
            Assert.Equal(6, myList.Count);
        }
        [Fact]
        public void can_remove()
        { 
            // Arrange
            Library <int> myList = new Library<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            // Act
            myList.Remove(3);


            // Assert
            Assert.Equal("{1}->{2}->{4}->{5}->{6}->",myList.ToString());
        }
    }
}
