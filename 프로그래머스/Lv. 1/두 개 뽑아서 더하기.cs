using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public List<int> solution(int[] numbers) {
        List<int> answer = new List<int>();
        
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                answer.Add(numbers[i] + numbers[j]);
            }
        }
        
        answer.Sort();
        answer = answer.Distinct().ToList();
        
        return answer;
    }
}

// contains 활용해서 만약 없으면 추가하고 있으면 넘어가는 로직을 만들어도 됨.
