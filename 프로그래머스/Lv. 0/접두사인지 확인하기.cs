using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 1;
        
        if (is_prefix.Length > my_string.Length)
        {
            answer = 0;
        }
        else
        {
            for (int i = 0; i < is_prefix.Length; i++)
        {
            if(my_string[i] != is_prefix[i])
            {
                answer = 0;
                break;
            }
        }
        }
        
        return answer;
    }
}
 //return my_string.IndexOf(is_prefix) == 0 ? 1 : 0;
// 조건 및 모든게 길어지는 코드 보단 간결한 코드가 보기에도 편함
// 여러 메서드를 숙지할 필요가 있음
