using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int> answer = arr.ToList();
        
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < delete_list.Length; j++)
            {
                if (arr[i] == delete_list[j])
                {
                    answer.Remove(arr[i]);
                    break;
                }
            }
        }
        
        return answer.ToArray();
    }
}
