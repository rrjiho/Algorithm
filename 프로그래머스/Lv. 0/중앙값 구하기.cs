using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        int mid = array.Length / 2;

        Array.Sort(array);

        answer = array[mid]; 

        // OrderBy 오름차순 정렬 사용
        //int answer = array.OrderBy(x => x).ToArray()[array.Length / 2];

        return answer;
    }
}
