using ClassLibrary.Abstraction;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class ArrayServices : IArrayServices
    {
        public ArrayServices(string data)
        {
        }

        public int[] FindTheLargestThree(int[] arr)
        {
            int first, second, third;
            int arrsize = arr.Length;

            // There should be atleast three elements
            if (arrsize < 3)
            {
                throw new Exception("Invalid Input");
            }

            third = first = second = 0;
            for (int i = 0; i < arrsize; i++)
            {

                // If current element is
                // greater than first
                if (arr[i] > first)
                {
                    third = second;
                    second = first;
                    first = arr[i];
                }

                // If arr[i] is in between first
                // and second then update second
                else if (arr[i] > second && arr[i] != first)
                {
                    third = second;
                    second = arr[i];
                }

                else if (arr[i] > third && arr[i] != second)
                    third = arr[i];
            }

            return new int[3] { first, second, third };
        }

        public int[] FindTheLargestThreeUsingSort(int[] arr)
        {
            int arrsize = arr.Length;
            // There should be atleast three elements
            if (arrsize < 3)
            {
                throw new Exception("Invalid Input");
            }


            int[] outputArray = new int[3];

            HashSet<int> distinctArrayHashSet = new HashSet<int>();


            for (int i = 0; i < arrsize; i++)
            {
                distinctArrayHashSet.Add(arr[i]);

            }

            int[] distinctArray = new int[3];
            distinctArray = distinctArrayHashSet.ToArray();
            Array.Sort(distinctArray);
            int distinctarrsize = distinctArray.Length;


            int insertcount = 0;
            for (int i = distinctarrsize - 1; i >= distinctarrsize - 3; i--)
            {

                outputArray[insertcount++] = distinctArray[i];
            }

            return outputArray;
        }

        public string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            char[] charsOutput = new char[chars.Length];
            string output = string.Empty;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                output += chars[i];
            }

            return output;
        }
    }

}
