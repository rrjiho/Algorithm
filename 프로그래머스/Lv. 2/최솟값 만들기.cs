using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;

        Array.Sort(A);
        Array.Sort(B);
        Array.Reverse(B);

        for (int i = 0; i < A.Length; i++)
            answer += A[i] * B[i];
        
        return answer;
    }
}

/*
public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;

        List<int> listA = A.ToList();
        List<int> listB = B.ToList();

        for (int i = 0; i < A.Length; i++)
        {
            answer += listA.Min() * listB.Max();
            listA.Remove(listA.Min());
            listB.Remove(listB.Max());
        }
        
        return answer;
    }
} 효율성 테스트 실패 Remove 과정 없이 진행할 수 있는 코드가 효율성 있다고 판단한 것 같음
*/
