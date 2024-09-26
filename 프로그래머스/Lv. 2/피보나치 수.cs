public class Solution {
    public int solution(int n) {
        int answer = 0;
        int[] arr = new int[n + 1];
        arr[0] = 0;
        arr[1] = 1;
        
        for (int i = 2; i < n + 1; i++)
        {
          // 결합법칙 -> 결국 1234567 나머지 구하는 문제. 따라서 시작부터 나머지로 연산하면 int형 오버플로우 발생 안 하고 진행 가능.
            arr[i] = (arr[i - 2] + arr[i - 1]) % 1234567;
        }
        answer = arr[n];
        
        return answer;
    }
}
