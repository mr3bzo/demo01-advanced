using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Xml.Linq;
using C_Advanced01G02;
using ConsoleApp1;

namespace Demo01
{
    internal class Program
    {
        static void Main()
        {
            //enerics
            //C# Festus 2005 Ct 2.0
            //Before 2005 Class object

            #region Generic Swap EX01
            // int A = 4, B = 5;
            // Console.WriteLine($"A:{A}");
            // Console.WriteLine($"B:{B}");
            // 
            // Console.WriteLine("*************** After swap *************");
            // 
            // Helper.SWAP(ref A, ref B); //Passing by Ref
            // 
            // Console.WriteLine($"A:{A}");
            // Console.WriteLine($"A:{A}");

            //double L = 4, K = 5;
            //Console.WriteLine($"L:{L}");
            //Console.WriteLine($"K:{K}");
            //
            //Console.WriteLine("*************** After swap *************");
            //
            //Helper.SWAP(ref L, ref K); //Passing by Ref
            //
            //Console.WriteLine($"L:{L}");
            //Console.WriteLine($"K:{K}");

            //Point P01 = new Point(1, 1);

            //Point P02 = new Point { 2, 2);

            //Console.WriteLine($"P01:{P01}");
            //Console.WriteLine($"P02:{P02}");

            //Console.WriteLine("*************** After swap *************");

            //Helper.SWAP(ref P01, ref P02);
            //Console.WriteLine($"P01:{P01}");
            //Console.WriteLine($"P02:{P02}"); 
            #endregion

            #region Generic Swap Ex02

            // // Linear Search
            // // 11 4 7 8 9 10 1 2 3 5 12 - 1 - 13 11
            // // Index

            // ////int Index = Helper. LinearSearch(Numbers, 4); // 6
            // // int Index = Helper.LinearSearch(Numbers, 12); // 9
            // //Console. WriteLine($"Index: (Index)");


            // Employee E01 = new Employee() { Id = 1, Name= "Ahmed", Salary = 12000, Age = 31 };
            // Employee E02 = new Employee() { Id = 2, Name ="Ali", Salary = 11000, Age = 34 };
            // Employee E03 = new Employee() { Id =3, Name=  "Omar", Salary = 13000, Age = 32 };
            // Employee E04 = new Employee() { Id = 4, Name= "Mona", Salary = 19000, Age = 29 };

            // Employee[] employees = (E01, E02, E03, E04);

            // Helper.LinearSearch(employees, E01);

            //int index= Helper.LinearSearch(employees, E01);
            // Console. WriteLine($"Index: (Index)"); 
            #endregion


            #region Equality in Class or Struct
            //// Equality in Class or Struct	
            //// Equals	
            //// 'Class' Has Equals Function Which Inherited From Object Class -> Compare Reference ==	
            //// 'Struct' Has Equals Function Which Inherited From Object Class -> Compare Data	
            //// NOTE: Struct Don't Have Implementation For The == Operator	

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 31 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 11000, Age = 34 };
            ////Console. WriteLine($"E01: (E01. GetHashCodeO}");	
            ////Console WriteLine($"E02: {E02. GetHashCode)}");	
            ////if (E01.Equals(E02))	
            ////Console.WriteLine("E01 == E02!");
            ////else	
            ////	Console. WriteLine("E01 |= E02!");	

            //if (E01 == E02)
            //    Console.WriteLine(value: "E01 == E02!");
            //else
            //    Console.WriteLine(value: "E01 != E02!"); 
            #endregion

            #region Bubblesorting
            //// 2, 3, 9,8,7,6, 5, 4, 1, 12,-1,0
            //// Sorting : Bubble Sort	
            //int[] Numbers = { 2, 3, 9, 8, 7, 6, 5, 4, 1, 12, -1, 03 };
            //Helper.PrintArray(Numbers);
            //Helper.BubbleSort(Numbers);

            //Point[] points = {
            //    new Point(x: 6, y: 6),
            //    new Point(x: 2, y: 2),
            //    new Point(x: 4, y: 4),
            //    new Point(x: 3, y: 3),
            //    new Point(x: 1, y: 1),
            //    new Point(x: 5, y: 5),
            //    };

            //Helper.BubbleSort(points);
            //// ICompareable : CompareTo	
            //// int	
            //// + : Caller > Parameter	
            //// - : Caller < Parameter	
            //// 0 : Caller = Parameter 
            #endregion

            #region non  generic Icomparable vs generic Icomparble 
            //Point[] points = {
            //    new Point(x: 6, y: 6),
            //    new Point(x: 2, y: 2),
            //    new Point(x: 4, y: 4),
            //    new Point(x: 3, y: 3),
            //    new Point(x: 1, y: 1),
            //    new Point(x: 5, y: 5),
            //    };

            //Helper.BubbleSort(points);

            // Employee E01 = new Employee() { Id = 1, Name= "Ahmed", Salary = 12000, Age = 31 };
            // Employee E02 = new Employee() { Id = 2, Name ="Ali", Salary = 11000, Age = 34 };
            // Employee E03 = new Employee() { Id =3, Name=  "Omar", Salary = 13000, Age = 32 };
            // Employee E04 = new Employee() { Id = 4, Name= "Mona", Salary = 19000, Age = 29 };

            // Employee[] employees = (E01, E02, E03, E04);

            // Helper.LinearSearch(employees, E01);

            #endregion

            #region Builtin Interface Generic IEquatable


            // Employee E01 = new Employee() { Id = 1, Name= "Ahmed", Salary = 12000, Age = 31 };
            // Employee E02 = new Employee() { Id = 2, Name ="Ali", Salary = 11000, Age = 34 };
            // Employee E03 = new Employee() { Id =3, Name=  "Omar", Salary = 13000, Age = 32 };
            // Employee E04 = new Employee() { Id = 4, Name= "Mona", Salary = 19000, Age = 29 };

            // Employee[] employees = (E01, E02, E03, E04);
            // Helper.LinearSearch(employees, E01);
            // Console. WriteLine($"Index: (Index)"); 
            if (E01.Equals(E02))
                Console WriteLine(value: "E01 == E02");
            else
                Console.WriteLine(value: "E01 != E02º) ;	
                    // Built -in Interface Generic IEquatabl 
                #endregion



                #region Builtin Interface Generic IEqualityComparer

                //     Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 31 };
                //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 11000, Age = 34 };
                //Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 13000, Age = 32 };
                //Employee E04 = new Employee() { Id = 4, Name = "Mona", Salary = 19000, Age = 29 };

                //Employee[] employees = (E01, E02, E03, E04);
                //Helper.LinearSearch(employees, E01);
                //Console.WriteLine($"Index: (Index)");
                ////int index = Helper.LinearSearch(employees, E01);
                //int index = Helper.LinearSearch(employees, new Employee() { Name = "Ali" });

                #endregion

                #region  Generic Constraints:	

                // Generic Constraints:	
                // 1. Primary Constraints [0 : 1]	
                // 1.1. class	
                // 1.1. struct	
                // 1.1. special type point	
                // 1.1. enum
                // 1.1. notnull
                // 2. Secondary Constraints [0: M]	
                // T Implement Interface	
                // 3. Constructor Constraints	 
                #endregion


    }
    }
}