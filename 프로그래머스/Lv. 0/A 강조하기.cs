using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        answer = myString.ToLower();
        
        answer = answer.Replace("a", "A");

        // return myString.ToLower().Replace('a', 'A');
        return answer;
    }
}
