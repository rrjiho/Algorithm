class Program
{ 
    static int BinarySearch(int[] arr, int x)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == x)
                return mid;
            else if (arr[mid] < x)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
  // 양 끝과 중간을 정하고 중간을 기준으로 큰 곳이면 right를 당겨 작은 곳이면 left를 당겨
  // 당기다가 left가 right를 넘어가면 못 찾는 수

    static void Main(string[] args)
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int x = 10;
        int result = BinarySearch(arr, x);
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
