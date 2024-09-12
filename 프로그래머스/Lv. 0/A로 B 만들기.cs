using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        
        char[] c_before = before.ToCharArray();
        char[] c_after = after.ToCharArray();
        
        int cnt = before.Length;
        for (int i = 0; i < c_before.Length; i++)
        {
            for (int j = 0; j < c_after.Length; j++)
            {
                if (c_after[j] == c_before[i])
                {
                    c_after[j] = ' ';
                    cnt--;
                    break;
                }
            }
        }
        if (cnt == 0)
            answer++;

        // Array.Sort(c_before);
        // Array.Sort(c_after); 이렇게 정렬하고 비교하면 훨씬 빠름

        // int answer = String.Concat(before.OrderBy(x=>x)) == String.Concat(after.OrderBy(x=>x)) ? 1 : 0;
        
        return answer;
    }
}
