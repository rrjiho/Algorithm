using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        List<int> frontList = new List<int>();
        List<int> backList = new List<int>();
        
        for (int i = 0; i < num_list.Length; i++)
        {
            if (i <= n - 1)
                backList.Add(num_list[i]);
            else
                frontList.Add(num_list[i]);
        }
        
        return frontList.Concat(backList).ToArray();
    }
}
