using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
             
        for (int i = 0; i < my_string.Length; i++)
        {
            char c = my_string[i];

            int cnt = 0;
            for (int j = 0 ; j < answer.Length; j++)
            {
                if (answer[j] == c)
                {
                    cnt++;
                }
            }
            if (cnt == 0) 
                answer += c;
        }
      
        // answer = string.Concat(my_string.Distinct()); -> 알고리즘 원리를 직접 짜는 것이 목표지만 구현된 기능을 무시하는 것은 비효율적. 두 가지 다 가져가야 함.
      
        return answer;
    }
}
