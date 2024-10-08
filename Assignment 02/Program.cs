﻿using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using System.Threading.Tasks;
using System.Linq;

namespace Assignment_02
{
    internal class Program
    {

        #region Part 02

        #region 1. You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

        public void ReverseArrayList(ArrayList arrayList)
            {
              int left = 0;
              int right = arrayList.Count - 1;

            while (left < right)
            {
                object temp = arrayList[left];
                arrayList[left] = arrayList[right];
                arrayList[right] = temp;

                left++;
                right--;
            }
        }

        #endregion

        #region 2. You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

        public List<int> GetEvenNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).ToList();
        }

        #endregion

        #region 3. implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.

        public class FixedSizeList<T>
        {
            private T[] items;
            private int count;

            public FixedSizeList(int capacity)
            {
                if (capacity <= 0)
                    throw new ArgumentException("Capacity Must be Greater Than Zero.", nameof(capacity));

                items = new T[capacity];
                count = 0;
            }

            public void Add(T item)
            {
                if (count >= items.Length)
                    throw new InvalidOperationException("Cannot Add Elements. The List Is Full.");

                items[count++] = item;
            }

            public T Get(int index)
            {
                if (index < 0 || index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Invalid index.");

                return items[index];
            }
        }
        #endregion


        #endregion
        static void Main(string[] args)
        {
            #region Part 01 Write a Report about all Collections Given in the Session and Compare [Structure, Time Complexity, and Business Case With Implemented Examples]

            //   1. Array
            //  [Structure]: A fixed-size collection of elements of the same type.
            //  [Time Complexity]:
            //      Access: (Constant Time Complexity)
            //      Search: (Linear Time Complexity) 
            //      Insertion: (Linear Time Complexity) 
            //      Deletion: (Linear Time Complexity) 
            //  [Business Case] : Useful when the size of the collection is known and fixed, and fast access to elements that is required.
            //  [Example] :
            //  int[] numbers = new int[5];


            // 2. ArrayList
            //  [Structure]: A dynamically sized array of objects.
            //  [Time Complexity]:
            //       Access: (Constant Time Complexity)
            //       Search: (Linear Time Complexity) 
            //       Insertion: (Linear Time Complexity) 
            //       Deletion: (Linear Time Complexity) 
            //  [Business Case] : Useful when the size of the collection can change dynamically, but type safety is not a concern.
            //  [Example] :
            //  ArrayList arrayList = new ArrayList();


            // 3. List<T>
            //  [Structure]: A generic dynamically sized array.
            //  [Time Complexity]:
            //       Access: (Constant Time Complexity)
            //       Search: (Linear Time Complexity) 
            //       Insertion: (Linear Time Complexity) 
            //       Deletion: (Linear Time Complexity) 
            //  [Business Case] : Provides type safety and is used when the size of the collection can change dynamically.
            //  [Example] :
            //  List<int> list = new List<int>();


            // 4. LinkedList<T>
            //  [Structure]: A doubly linked list of nodes, each containing a value and pointers to the next and previous nodes.
            //  [Time Complexity]:
            //       Access: (Linear Time Complexity) 
            //       Search: (Linear Time Complexity) 
            //       Insertion: (Constant Time Complexity)
            //       Deletion: (Constant Time Complexity)
            //  [Business Case] : Useful for efficient insertions and deletions, especially when working with sequential data where the cost of shifting elements is high.
            //  [Example] :
            //  LinkedList<int> linkedList = new LinkedList<int>();


            // 5. Stack<T>
            //  [Structure]:(Last-In - First - Out) collection.
            //  [Time Complexity]:
            //       Access: (Linear Time Complexity) 
            //       Search: (Linear Time Complexity) 
            //       Insertion: (Constant Time Complexity)
            //       Deletion: (Constant Time Complexity)
            //  [Business Case] : Useful for scenarios where you need to access the most recently added elements first, such as undo functionality in applications.
            //  [Example]:
            //  Stack<int> stack = new Stack<int>();


            //   6. Queue<T>
            //  [Structure]:(First-In - First - Out) collection.
            //  [Time Complexity]:
            //       Access: (Linear Time Complexity) 
            //       Search: (Linear Time Complexity) 
            //       Insertion: (Constant Time Complexity)
            //       Deletion: (Constant Time Complexity)
            //  [Business Case] : Useful for processing elements in the order they were added, such as in task scheduling or print queues.
            //  [Example] :
            //  Queue<int> queue = new Queue<int>();


            #endregion




            //FixedSizeList<int> fixedList = new FixedSizeList<int>(3);
            //try
            //{
            //    fixedList.Add(1);
            //    fixedList.Add(2);
            //    fixedList.Add(3);
            //    // fixedList.Add(4);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine("FixedSizeList items: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    try
            //    {
            //        Console.Write(fixedList.Get(i) + " ");
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
        }
    }
}
