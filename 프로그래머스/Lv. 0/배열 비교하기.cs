using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        
        if (arr1.Length != arr2.Length)
        {
            answer = arr1.Length > arr2.Length ? 1 : -1;
        }
        else if(arr1.Length == arr2.Length)
        {
            if (arr1.Sum() != arr2.Sum())
                answer = arr1.Sum() > arr2.Sum() ? 1 : -1;
            else if (arr1.Sum() == arr2.Sum())
                answer = 0;
        }
        
        return answer;
    }
}
