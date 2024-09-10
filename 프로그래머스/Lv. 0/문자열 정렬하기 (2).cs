using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        char[] c = my_string.ToLower().ToCharArray();
        Array.Sort(c);
        
        answer = new string(c);
        
        return answer;
    }
}
