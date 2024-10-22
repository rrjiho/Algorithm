using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;
        
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            if (dict.ContainsKey(clothes[i, 1]))
                dict[clothes[i, 1]]++;
            else
                dict[clothes[i, 1]] = 1;
        }
        
        foreach (var count in dict.Values)
            answer *= (count + 1); // 선택하지 않음을 포함한 경우의 수
        
        answer--; // 아무것도 입지 않은 경우 제외
        
        return answer;
    }       
}
