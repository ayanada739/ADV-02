using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal class Program
    {
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
        }
    }
}
