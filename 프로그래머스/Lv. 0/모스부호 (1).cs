using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] mos = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        
        foreach(string s in letter.Split(' '))
        {
            answer += Convert.ToChar(Array.IndexOf(mos, s) + 97);
        }
        
        return answer;
    }
}
