using System;

class Solution 
{
    public int solution(int n) 
   {
        int answer = 0;
        string n_binary = Convert.ToString(n, 2);
        int oneCount = 0;
        foreach (char c in n_binary)
        {
            if (c == '1')
                oneCount++;
        }
        
        int cnt = 1;
        while(true)
        {
            int resultoneCount = 0;
            string result_binary = Convert.ToString(n + cnt, 2);
            foreach (char c in result_binary)
            {
                if (c == '1')
                    resultoneCount++;
            }
            
            if (oneCount == resultoneCount)
            {
                answer = n + cnt;
                break;
            }            
            cnt++;             
        }      
        return answer;
    }
}

/* 위 풀이와 같은 논리연산이지만 눈에 확 들어오고 이해하기도 쉬움. C#을 계속 사용할거라면 LINQ 사용을 충분히 익혀서 적용할 필요가 있음.
    자바 파이썬은 C#과 같이 내장 클래스 함수로 쉽게 풀이가 가능하고 C++은 비트 연산을 통해 문제를 해결할 수 있음.
    현재는 C#으로 문제를 풀고 있으니 LINQ 익힐 것.
int oneCount = Convert.ToString(n, 2).ToArray().Where(x => x == '1').Count();
while (true)
{
  n++;
  if (oneCount == Convert.ToString(n, 2).ToArray().Where(x => x == '1').Count())
      break;
}
return n; 
*/
