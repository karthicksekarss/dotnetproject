namespace ClassLibrary.Abstraction
{
    public interface IArrayServices
    {
        int[] FindTheLargestThree(int[] inputArray);
        int[] FindTheLargestThreeUsingSort(int[] arr);

        string ReverseString(string str);
    }
}
