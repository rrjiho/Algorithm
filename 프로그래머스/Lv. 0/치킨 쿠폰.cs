using System;

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        int remain = 0;
        
        while(chicken >= 10)
        {
            answer += chicken / 10;
            remain = chicken % 10;
            
            chicken /= 10;
            chicken += remain;
        }
        // 어차피 쿠폰은 남은 치킨에 종속시켜도 같음
        return answer;
    }
}
