using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int idx1 = 0; 
        int idx2 = 0; 

        foreach (string word in goal)
        {
            if (idx1 < cards1.Length && cards1[idx1] == word)
            {  
                idx1++;
            }
            else if (idx2 < cards2.Length && cards2[idx2] == word)
            {
                idx2++;
            }
            else
            {
                return "No";
            }
        }

        return "Yes";
    }
} // 코드 작성 전 해결 규칙을 정하고 시작하는 편이 수월함.
