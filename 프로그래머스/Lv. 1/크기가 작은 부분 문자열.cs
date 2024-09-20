using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        for (int i = 0; i < t.Length - p.Length + 1; i++)
        {
            string s = t.Substring(i, p.Length);
            if (long.Parse(s) <= long.Parse(p))
                answer++;
        }// int 범위 초과하는 것 항상 염두해야함

        return answer;
    }
}
