using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Collections.Generic;
using System;

namespace Assignment01advanced
{
    class program
    {
        #region 01
        // 01 The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases,
        // which makes it inefficient for large datasets. How we can optimise the Bubble Sort algorithm 
        //And implement the code of this optimised bubble sort algorithm

        public static void OptimizedBubbleSort<T>(T[] array) where T : IComparable<T>
        {
            bool swap;
            for (int i = 0; i < array.Length - 1; i++)
            {
                swap = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swap = true;
                    }
                }

                if (!swap)
                    break;
            }
        }
        #endregion
        #region Ex02
        //      02  create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.The range should support basic operations such as checking if a value is within the range and determining the length of the range.
        //Requirements:
        //Create a generic class named Range<T> where T represents the type of values.
        //Implement a constructor that takes the minimum and maximum values to define the range.
        //Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
        //Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
        //Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.

        // 01 Create a generic class named Range<T> where T represents the type of values.

        //public class Range<T> where T : IComparable<T>
        //{
        //    private T minimum;
        //    private T maximum;

        //    // 02 Implement a constructor that takes the minimum and maximum values to define the range.

        //    public Range(T minimum, T maximum)
        //    {
        //        this.minimum = minimum;
        //        this.maximum = maximum;
        //    }
        //    // 03 Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.

        //    public bool IsInRange(T value)
        //    {
        //        bool Minimum = value.CompareTo(minimum) >= 0;
        //        bool Maximum = value.CompareTo(maximum) <= 0;

        //        return Minimum && Maximum;
        //    }
        //    // 04 Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).

        //    public T Length()
        //    {
        //        T min = minimum;
        //        T max = maximum;
        //        return max - min;
        //    }
        //}

        #endregion


        #region Ex03
        //03 You are given an ArrayList containing a sequence of elements.
        //try to reverse the order of elements in the ArrayList in-place(in the same arrayList)
        //without using the built-in Reverse.Implement a function that takes the ArrayList as
        //input and modifies it to have the reversed order of elements.

        public static void ReverseArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;
            while (start < end)
            {
                // Swap elements from start and end
                object temp = list[start];
                list[start] = list[end];
                list[end] = temp;

            }
        }
        #endregion

        #region Ex04
        // 04 You are given a list of integers.Your task is to find and return a new list containing only the even numbers from the given list.

        public static List<int> FilterEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }
            return evenNumbers;
        }
        #endregion

        #region Ex05

        // 05 implement a custom list called FixedSizeList<T> with a predetermined capacity.
        // This list should not allow more elements than its capacity and should provide clear messages
        // if one tries to exceed it or access invalid indices.


        // 01 Create a generic class named FixedSizeList<T>.

        public class FixedSizeList<T>
        {
            private T[] items;  // Internal array to store elements
            private int count;  // Tracks the current number of elements



            // 02 Implement a constructor that takes the fixed capacity of the list as a  parameter.
            public FixedSizeList(int capacity)
            {
                items = new T[capacity];
                count = 0;
            }

           // 03 Implement an Add method that adds an element to the list, but throws an exception if the list is already full.

            public void Add(T item)
            {
                if (count >= items.Length)
                {
                    throw new InvalidOperationException("Cannot add more elements. The list is full.");
                }

                items[count] = item;
                count++;
            }

             // 04 Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.

            public T Get(int index)
            {
                if (index < 0 )
                {
                    throw new IndexOutOfRangeException("Index is out of bounds.");
                }

                return items[index];
            }

        }
        #endregion
        #region 06
        // 06 Given a string, find the first non-repeated character in it and return its index.If there is no such character, return -1. Hint you can use dictionary

        //public int FirstNonRepeatedCharacter(string str)
        //{
        //    Dictionary<char, int> charCount = new Dictionary<char, int>();

        //    foreach (char c in str)
        //    {
        //        if (charCount.ContainsKey(c))
        //        {
        //            charCount[c]++;
        //        }
        //        else
        //        {
        //            charCount[c] = 1;
        //        }
        //    }

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (charCount[str[i]] == 1)
        //        {
        //            return i;
        //        }
        //    }

        //    return -1;
        //}

        #endregion














    }
}