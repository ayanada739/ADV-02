using System.Collections;
using System.Collections.Generic;

namespace ADV_02
{
    internal class Program
    {
        public static int SumarrayList(ArrayList arrayList)
        {
            int Sum = 0;
            if (arrayList is not null)
                for (int i = 0; i < arrayList.Count; i++)
                     Sum += (int) arrayList [i]; // Casting From Object To int
                                                 //Un Boxing
                                                 // Unsafe
            return Sum;
        }


        static void Main(string[] args)
        {
            #region Non_Generic Collections - ArrayList
            ////    ArrayList arrayList = new ArrayList();
            ////    //arrayList => Size 0


            ////    Console.WriteLine($"Count Of arrayList = {arrayList . Count} ,Capacity Of arrayList = {arrayList . Capacity}"); //0 ,0
            ////    // Count ==> Actual Number Of Elements In array List
            ////    // Capacity => Numbers Of Elements That Can be Holed


            ////    arrayList.Add(1);
            ////    // Upon adding the first element to the list the capacity is
            ////    // increased to —defaultCapacity = 4
            ////    // Create New Array In Heap With Size 4

            ////    Console.WriteLine("After Adding First Element");
            ////    Console.WriteLine($"Count Of arrayList = {arrayList.Count} ,Capacity Of arrayList = {arrayList.Capacity}"); //1 ,4


            ////    arrayList.Add(2);
            ////    Console.WriteLine($"Count Of arrayList = {arrayList.Count} ,Capacity Of arrayList = {arrayList.Capacity}"); //2 , 4

            ////    arrayList.AddRange(new int[] { 3, 4 });
            ////    Console.WriteLine($"Count Of arrayList = {arrayList.Count} ,Capacity Of arrayList = {arrayList.Capacity}"); // 4,4

            ////    arrayList.Add(5);
            ////    //Create New Array In Double Size Of Old Array [8]
            ////    //Take old Elements And Adding New Element To New Array


            ////    Console.WriteLine("After Adding fifth Element");
            ////    Console.WriteLine($"Count Of arrayList = {arrayList.Count} ,Capacity Of arrayList = {arrayList.Capacity}"); //5 , 8



            //ArrayList arrayList = new ArrayList(5) { 1 , 2 , 3 , 4 , 5 };
            //Console.WriteLine($"Count Of arrayList = {arrayList.Count} ,Capacity Of arrayList = {arrayList.Capacity}");//5 , 5

            //arrayList.Add(6);
            ////Create New Array In Double Size Of Old Array [10]
            ////Take old Elements And Adding New Element To New Array
            //Console.WriteLine("After Adding 6th Element");
            //Console.WriteLine($"Count Of arrayList = {arrayList.Count} ,Capacity Of arrayList = {arrayList.Capacity}"); //6 , 10

            //// 10 - 6 = 4 [Address Of Object] = 16 Bytes [Unused Bytes]
            //arrayList.TrimToSize(); //Dealloocate || Free || Delete Unused Bytes
            //                        // Create New array At Heap With Size
            //                        // Take Old Elements Of Old Array
            //                        // Old Array Now Is Unreachable

            //Console.WriteLine("After Trim");
            //Console.WriteLine($"Count Of arrayList = {arrayList.Count} ,Capacity Of arrayList = {arrayList.Capacity}"); //6 , 6

            //arrayList.Add(1); ; // Casting (1) Value Type To (Object) Reference Type
            //                    // Boxing

            // arrayList.Add("Aliaa");// InvalidCastException
            //                        //array List ==> Heterogeneous List [غير متجانسه]
            //                        // Compilar Cannot Enforce Type Safe

            //int result = SumarrayList(arrayList);
            //Console.WriteLine(result);
            ////foreach (var item in arrayList)
            ////{
            ////    Console.WriteLine(item);
            ////} 
            #endregion


        }
    }
}
