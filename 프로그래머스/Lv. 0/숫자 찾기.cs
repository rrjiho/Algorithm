using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        
        string s = num.ToString();
        char c = (char)(k + 48);
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == c)
            {
                answer = i + 1;
                break;
            }    
            else
                answer = -1;     
        }

        // int answer = num.ToString().IndexOf(k.ToString()) + 1; -> .Indexof(n) index 추출 (해당 없으면 return -1)
        // return answer == 0 ? answer = -1 : answer;
      
        return answer;
    }
}
