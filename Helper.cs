using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced01G02

{

    internal static class Helper<T>
    {

        #region Generic Swap
        //public static void SWAP<T>(ref T X, ref T Y)
        //{
        //    T Temp = X;
        //    X = Y;
        //    Y = Temp;

        //}
        //public static void Print(T data)
        //    (
        //    Console.WriteLine(data);
        //    ) 
        #endregion

        #region Non Generic Swap
        //public static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;

        //}

        //public static void SWAP(ref double X, ref double int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;

        //}
        //public static void SWAP(ref Point X, point int Y)
        //{
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;

        //}
        #endregion

        #region Non Generic LinerSearch
        //public static int LinearSearch(int[] Arr, int Value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] == Value) return i;
        //        }
        //    }
        //    return -1;
        //} 
        #endregion

        #region Generic linersearch
        //public static int LinearSearch<T>(T[] Arr, T Value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i].Equals(Value)) return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion
        #region Non Generic bubblesorting
        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; 1 < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length-i - 1 ; j++)
        //            {
        //                if (Arr[j] > Arr[j + 1])
        //                    SWAP(ref Arr[j], ref Arr[j + 11]);
        //            }
        //        }
        //    }
        //} 
        #endregion

        #region Icomparable
        public static void BubbleSort<T>(T[] Arr) where T : IComparable
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; 1 < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]))
                            SWAP(ref Arr[j], ref Arr[j + 11]);
                    }
                }
            }
        }
        #endregion

        public static int LinearSearch<T>(T[] Arr, T Value, IEqualityComparer<T> equalityComparer)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (equalityComparer.Equals(Arr[i],Value) return i;
                }
            }
            return -1;
        }
    }
}