using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length];
        
        List<int> list = new List<int>();
        
        for (int i = num_list.Length - 1; i >= 0; i--)
        {
            list.Add(num_list[i]);
        }
        
        answer = list.ToArray();

        // Array.Reverse(num_list); 
        // return num_list; 가능
      
        return answer;
    }
}
