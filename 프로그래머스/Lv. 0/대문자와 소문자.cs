using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        for (int i = 0; i < my_string.Length; i++)
        {
            if (char.IsUpper(my_string[i]))
                answer += char.ToLower(my_string[i]);
            else
                answer += char.ToUpper(my_string[i]);
        }
        
        return answer;
    }
}
