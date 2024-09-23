using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        HashSet<char> skipSet = new HashSet<char>(skip);
        
        foreach (char c in s) {
            char currentChar = c;
            int count = 0;

            while (count < index) {
                currentChar++;
                
                if (currentChar > 'z') {
                    currentChar = 'a';
                }
                
                if (!skipSet.Contains(currentChar)) {
                    count++;
                }
            }
            
            answer += currentChar;
        }
        /* HashSet 사용 이유 (조금 더 성능이 좋아질 수 있는 것도 고려해 볼 만한 이슈)
          - List or string Contains 사용하면 O(n) 만큼 시간 더 소요
          - HashSet 사용하면 O(1)로 줄어듦
          - 특징: 중복 허용 안함, 순서가 없음, 빠른 속도
          - 따라서 순서나 중복이 중요하지 않은 자료는 사용에 속도 이점이 있음
          - 여기서 skip 변수 -> 문제에서 주어진 조건이 HashSet과 맞아 떨어짐
        */
        return answer;
    }
}
