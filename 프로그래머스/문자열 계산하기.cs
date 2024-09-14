using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string[] str = my_string.Split(" ");
        
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i] == "+")
            {
                answer += Int32.Parse(str[i + 1]);
                i++;
            }
            else if(str[i] == "-")
            {
                answer -= Int32.Parse(str[i + 1]);
                i++;
            }
            else
                answer += Int32.Parse(str[i]);
        }
        
        
        return answer;
    }
}
