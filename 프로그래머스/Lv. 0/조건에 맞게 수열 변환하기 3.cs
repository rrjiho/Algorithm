using System;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = new int[arr.Length];
        
        if (k % 2 == 0)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i] + k;
            }
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i] * k;
            }
        }
        
        return answer;
    }
}
// for { 삼항 연산자 } 하는 게 더 가독성 좋을 수 있다. (for 두 번 똑같은 것을 쓰는 것보다)
