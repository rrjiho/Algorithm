using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        
        for (int i = 1; i <= cipher.Length; i++)
        {
            if (i % code == 0)
                answer += cipher[i - 1];
        }
        
        return answer;
    }
}
