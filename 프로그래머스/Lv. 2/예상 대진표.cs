using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;

        while (a != b)
        {
            if(a % 2 == 0)
                a = a / 2;
            else
                a = (a + 1) / 2;
            
            if(b % 2 == 0)
                b = b / 2;
            else
                b = (b + 1) / 2;
            answer++;
        }

        return answer;
    } // 수학적으로 해결했지만 n을 활용하지 않은 것이 출제 의도와 다를 수 있다는 것.
}

// 문제 해석에 따라 여러 방법을 사용할 수 있음.
// 처음 실패 원인은 시간 초과 및 문제 해석 오류.
