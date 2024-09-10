using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> list = new List<int>();
        
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                list.Add(i);
        }
        
        int[] answer = list.ToArray();

        // int[] answer = Enumerable.Range(1, n).Where(x => n % x == 0).ToArray();
      
        return answer;
    }
}
