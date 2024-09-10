using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        
        char[] c = my_string.ToCharArray();
        char temp;
        
        temp = c[num1];
        c[num1] = c[num2];
        c[num2] = temp;
        
        answer = String.Concat(c);
        // ex) my_string[num1] = 's'; <- error: string.this[int] = readonly
        return answer;
    }
}
