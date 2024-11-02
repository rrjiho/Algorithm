using System;

public class Solution {
    public int solution(string my_string, string target) {
        int answer = 0;
        
        for (int i = 0; i <= my_string.Length - target.Length; i++)
        {
            bool isSubstring = true;
            
            for (int j = 0; j < target.Length; j++)
            {
                if (my_string[i + j] != target[j])
                {
                    isSubstring = false;
                    break;
                }
            }
            
            if (isSubstring)
            {
                answer = 1;
                break;
            }
        }
        // 이전 부분문자열 문제와 동일.
        return answer;
    }
}
