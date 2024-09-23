using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        foreach (char c in s)
        {
            if (char.IsLower(c) && c + n <= (int)'z')
                answer += (char)(c + n);
            else if (char.IsLower(c) && c + n > (int)'z')
                answer += (char)(c + n - 26);
            else if (char.IsUpper(c) && c + n <= (int)'Z')
                answer += (char)(c + n);
            else if (char.IsUpper(c) && c + n > (int)'Z')
                answer += (char)(c + n - 26);
            else if (c == ' ')
                answer += " ";
        }
        
        return answer;
    }
}
