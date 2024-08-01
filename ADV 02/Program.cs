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


        public static int SumList(List<int> List)
        {
            int Sum = 0;
            if (List is not null)
                for (int i = 0; i < List.Count; i++)
                    Sum += (int)List[i];  
                                                                
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

            #region Generic Collections - List
           // //List ==> ArrayList Version With Generic

           // //List<int> Numbers = new List<int>();
           // //Console.WriteLine($"Count Of List = {Numbers. Count} ,Capacity Of arrayList = {Numbers. Capacity}"); //0,0
           // //Numbers.Add(1);
           // ////Upon adding the first element to the list the capacity is
           // //// incheased to DéfauttCÅpacity = 4
           // //// Create New array at Heap With Size =4
           // //Console.WriteLine($"Count Of List = {Numbers.Count} ,Capacity Of arrayList = {Numbers.Capacity}"); //1,4

           // //Numbers.Add(2);
           // //Numbers.AddRange(new int[] { 3 , 4 });
           // //Console.WriteLine($"Count Of List = {Numbers.Count} ,Capacity Of arrayList = {Numbers.Capacity}"); //4,4


           // //Numbers.Add(5);
           // //Console.WriteLine("After Adding 5th Element");
           // //Console.WriteLine($"Count Of List = {Numbers.Count} ,Capacity Of arrayList = {Numbers.Capacity}"); //5,8

           // //// 8 - 5 = 3 * 4 = 12 Bytes Unused

           // //Numbers.TrimExcess(); // Delete Unused Bytes
           // //Console.WriteLine("After Trim");
           // //Console.WriteLine($"Count Of List = {Numbers.Count} ,Capacity Of arrayList = {Numbers.Capacity}"); //5,5




           // List<int> Numbers = new List<int>(5) { 1 , 2 , 3 , 4 , 5 };
           //// Console.WriteLine($"Count Of List = {Numbers.Count} ,Capacity Of arrayList = {Numbers.Capacity}"); //5,5

           // Numbers.Add(6);
           // // Console.WriteLine($"Count Of List = {Numbers.Count} ,Capacity Of arrayList = {Numbers.Capacity}"); //6,10

           // //foreach (var item in Numbers)
           // //{
           // //    Console.WriteLine(item);
           // //}
           // Numbers[3] = 40;
           // //Using Indexer To Set Value
           // for (int i = 0; i < Numbers.Count; i++)
           // {
           //     Console.WriteLine(Numbers[i]);
           // }
           // //Using Indexer To Get Value

           // //Numbers[6] = 100; // OutOfRangeException
           // //Cannot Use Indexer To Add Element

           // Numbers.Add(100);


           // int Result = SumList(Numbers);
           // Console.WriteLine(Result);
            #endregion
        }
    }
}
