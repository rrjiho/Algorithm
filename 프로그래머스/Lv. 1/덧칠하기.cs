using System;
using System.Linq;
public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int currentPos = 0;
        
        foreach (int s in section)
        {
            if (s > currentPos)
            {
                answer++;
                currentPos = s + m - 1;
            }
        }
         // 현재 위치를 갱신하여 떨어진 만큼 횟수를 늘리는 방법.
        return answer;
    }
}

/*using System;
using System.Linq;
public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int len = section.Max() - section.Min() + 1;
        
        if (len >= m && len % m == 0)
        {
            answer += len / m;
        }
        else
        {
            answer += len / m + 1;
        }
     
        return answer;
    } 수학적으로 쉽게 풀려고 했으나 오류가 있음.
      연속된 구간만을 생각하고 만든 로직이 되었음.
}*/
