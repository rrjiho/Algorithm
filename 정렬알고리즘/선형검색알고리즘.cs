class Program
{ 
    static int LinearSearch(int[] arr, int x)
    {
        int len = arr.Length;
        for (int i = 0; i < len; i++)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }
    // 단순하게 하나씩 검색해보고 결과를 도출
  
    static void Main(string[] args)
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int x = 10;
        int result = LinearSearch(arr, x);
        if (result == -1)
        {
            Console.WriteLine("Element not found");
        }
        else
        {
            Console.WriteLine("Element found at index " + result);
        }
    }
}
