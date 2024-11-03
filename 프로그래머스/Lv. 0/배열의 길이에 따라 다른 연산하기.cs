using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = new int[arr.Length];
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr.Length % 2 == 0 && i % 2 != 0)
            {
                answer[i] = arr[i] + n; 
            }
            else if (arr.Length % 2 != 0 && i % 2 == 0)
            {
                answer[i] = arr[i] + n;
            }
            else
            {
                answer[i] = arr[i];
            }
        }
        // 굳이 answer 사용하지 않아도 됨.
        return answer;
    }
}
