using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0;
        
        for (int i = 0; i <= str2.Length - str1.Length; i++)
        {
            bool isSubstring = true;
            
            for (int j = 0; j < str1.Length; j++)
            {
                if (str2[i + j] != str1[j])
                {
                    isSubstring = false;
                    break;
                }
                    
            }
            
            if (isSubstring)
            {
                answer = 1;
                break;
            }
                
        }
        
        //answer = str2.Contains(str1) ? 1 : 0;
        // for 문으로 하나 Contains로 하나 속도는 비슷함.
        // 단 for를 통해 로직을 이해하는 것이 필요함.
      
        return answer;
    }
}
