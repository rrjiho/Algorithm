using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        
        for(int i = 0; i < numbers.Length; i++)
        {
            if(direction == "right")
            {
                if(i == 0)
                    answer[i] = numbers[numbers.Length - 1];
                else
                    answer[i] = numbers[i - 1];
            }
            if(direction == "left")
            {
                if(i == numbers.Length - 1)
                    answer[i] = numbers[0];
                else
                    answer[i] = numbers[i + 1];
            }
        }
        
        return answer;
    }
}
