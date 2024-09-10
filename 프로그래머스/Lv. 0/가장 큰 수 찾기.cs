using System;

public class Solution {
    public int[] solution(int[] array) {
        int n = 2;
        int[] answer = new int[n];
            
        int _max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
             if(_max < array[i])
             {
                 _max = array[i];
                 answer[0] = _max;
                 answer[1] = i;
             }
        }
        // int[] answer = new int[2] {array.Max(), Array.IndexOf(array, array.Max())};
        return answer;
    }
}
