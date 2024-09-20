using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> list = new List<int>();
        
        while (n > 0)
        {
            int a = n % 3;
            list.Add(a);
            n /= 3;
        }
        list.Reverse();
        
        for (int i = 0; i < list.Count; i++)
        {
            answer += (int)(list[i] * Math.Pow(3, i));
        }
        
        return answer;
    }
}
