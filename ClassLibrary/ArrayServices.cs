using ClassLibrary.Abstraction;

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
    }

}
