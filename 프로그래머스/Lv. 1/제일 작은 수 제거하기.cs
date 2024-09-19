using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> answer = arr.ToList();

        int min = answer.Min();
        answer.Remove(min);

        if (answer.Count < 1)
            answer.Add(-1);

        return answer.ToArray();
    }
}
