using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;

        for (int i = 1; i <= number; i++)
        {
            int cnt = 0;
            int sqrt = (int)Math.Sqrt(i);
            for (int j = 1; j <= sqrt; j++)
            {
                if (i % j == 0)
                {
                    cnt++;
                    if (j != i / j)
                    {
                        cnt++; 
                    }
                }
            }
            
            if (cnt > limit)
            {
                answer += power;
            }      
            else
            {
                answer += cnt;
            }
        }
        
        return answer;
    }
}
/*
이중 반복문으로 자칫 number가 커지면 복잡도가 O(n^2)으로 급격하게 증가할 수 있음
따라서 약수는 대칭이라는 성질을 이용하여 O(n*sqrt(n)) 만큼 줄이는 것이 효율적임
1 x 36
2 x 18
3 x 12
4 x 9
6 x 6
숫자 i에 대해 1부터 √i까지 반복하면서 i % j == 0인 경우를 찾고
j가 i의 약수이면, i / j도 약수임이 보장되므로 두 개의 약수를 한 번에 찾을 수 있음
단, j와 i / j가 같은 경우(예: 6 × 6)에는 한 번만 카운트해야 함
*/
