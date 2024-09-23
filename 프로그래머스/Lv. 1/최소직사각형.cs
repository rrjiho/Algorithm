using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        List<int> list = new List<int>();
        int max = 0;
        
        for (int i = 0; i < sizes.Length / sizes.Rank; i++)
        {
            int min = 1000;
            for (int j = 0; j < sizes.Rank; j++)
            {
                if (min > sizes[i, j])
                    min = sizes[i, j];
                
                if (max < sizes[i, j])
                    max = sizes[i, j];
            }
            list.Add(min);
        }
        
        answer = list.Max() * max;
        
        return answer;
    }
}
