using System;

public class Solution {
    public string solution(string rny_string) {
        string answer = "";
        
        foreach (char c in rny_string)
        {
            if (c == 'm')
            {
                answer += "rn";
            }
            else
            {
                answer += c;
            }
        }
        // answer.Replace("m", "rn") -> string, string or char, char 같은 것으로 변환 가능.
        return answer;
    }
}
