using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        char[] chars = n.ToString().ToCharArray();
        
        Array.Sort(chars);
        Array.Reverse(chars);
        
        string s = new string(chars);
        
        answer = long.Parse(s);
        return answer;
    }
}
