using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        
        string str = order.ToString();
        
        foreach(char num in str)
            if(num == '3' || num == '6' || num == '9')
                answer++;

        // n % 10 , n / 10 으로 하나씩 숫자를 지워가며 비교해서 ++ 해줘도 됨. (숫자 관점)
        
        return answer;
    }
}
