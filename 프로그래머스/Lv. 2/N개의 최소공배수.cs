using System;

public class Solution {
    // 최대공약수를 구하는 함수 <유클리드 호제법>
    public int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    
    // 최소공배수를 구하는 함수 <두 수의 최대공약수 이용>
    public int LCM(int a, int b) {
        return a * b / GCD(a, b);
    }

    // 모든 수에 대해 최소공배수 구하고 마지막을 answer
    public int solution(int[] arr) {
        int answer = arr[0];   
        for (int i = 1; i < arr.Length; i++) {
            answer = LCM(answer, arr[i]);
        }

        return answer;
    }
}



// 밑의 방법은 몇 케이스에서 실패로 뜨는 것 뿐만 아니라 매우 비효율적인 방법임.
// 수학 문제는 사용 방법을 익혀서 적용하는 편이 효율적이고 속도가 빠름.
/*public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        
        int max = arr[arr.Length - 1];
        int cnt = 1;

        Array.Sort(arr);
        
        while (true)
        {        
            int commul = max * cnt++;
            int totalCnt = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (commul % arr[i] != 0)
                {
                    continue;
                }
                else
                {
                    totalCnt++;
                }
            }
            if (totalCnt == arr.Length - 1)
            {
                answer = commul;
                break;
            }        
        }
                
        return answer;
    }
}*/
