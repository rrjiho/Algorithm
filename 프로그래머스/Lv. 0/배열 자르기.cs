using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2)
    {
        int n = num2 - num1 + 1;
    
        int[] answer = new int[n]; 
    
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i < num1 || i > num2)
                continue;
            else
            {
                answer[i - num1] = numbers[i];
            }
        }
    
        return answer;
    }
}
