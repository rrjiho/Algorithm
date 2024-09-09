using System;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[numbers.Length];
        
        for(int i = 0; i < numbers.Length; i++)
        {
            answer[i] = numbers[i] * 2;
        }

        // 기본 반환 값은 IEnumerable 타입이기 때문에 배열로 변환 ToArray 필요
        // int[] answer = numbers.Select(x => x * 2).ToArray();
      
        return answer;
    }
}
