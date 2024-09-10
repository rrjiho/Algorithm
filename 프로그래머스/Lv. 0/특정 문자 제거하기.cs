using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        
        foreach (char c in my_string)
        {
            if(c != char.Parse(letter))
                answer += c;
        }

        // answer = my_strring.Replace(letter, ""); 간단하게도 가능
      
        return answer;
    }
}
