using System;

class Solution
{
    public int solution(int n)
    {
        int answer = 0;

        if (n % 2 != 0)
            answer++;
        
        while (n != 0)
        {
            n /= 2;
            if (n % 2 != 0)
            {
                n -= 1;
                answer++;
            }
        }
        
        return answer;
    } // 2를 나누며 홀수일 시 하나씩 추가하는 로직
}

/* 더 효율적인 로직은 2를 나눈 나머지 즉, 홀수가 될 경우 1씩 추가하는 로직
using System;

class Solution
{
    public int solution(int n)
    {
        int answer = 0;

        while(n > 1)
        {
            answer += n % 2;
            n /= 2;
        }
        return answer + 1; // 마지막 n = 1인 경우 로직을 빠져나오기 때문에 마지막에 1을 추가해 줌.
    }
}

결국 이러한 유형은 수학적으로 생각하면 됨.
*/
