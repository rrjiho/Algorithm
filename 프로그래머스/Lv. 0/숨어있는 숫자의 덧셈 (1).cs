using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        char _zero = '0';
        char _nine = '9';

        foreach (char c in my_string)
        {
            if (c >= _zero && c <= _nine)
            {
                answer += (int)c - 48;
            }
        }
        
        return answer;
    }
}
