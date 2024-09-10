using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        
        string s = age.ToString();
        
        foreach(char c in s)
            answer += (char)(c + 49);
        // ASCII 48 -> 0 따라서 조건에서 0 -> a 변환이므로 +49
        return answer;
    }
}
