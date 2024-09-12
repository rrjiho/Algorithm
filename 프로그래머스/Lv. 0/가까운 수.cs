using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        
        int min = Math.Abs(array[0] - n);
        answer = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            int diff = Math.Abs(array[i] - n);
            if (min > diff)
            {
                min = diff;
                answer = array[i];
            }
            else if (min == diff)
            {
                if (array[i] < answer)
                    answer = array[i];
            }
        }
        
        return answer;
    }
}
