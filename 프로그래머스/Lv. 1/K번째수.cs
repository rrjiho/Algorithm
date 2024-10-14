using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {

        int len = commands.GetLength(0);
        int[] answer = new int[len];
        
        for (int u = 0; u < len; u++)
        { 
            int i = commands[u, 0];
            int j = commands[u, 1];
            int k = commands[u, 2];
            
            int[] target = new int[j - i + 1];
            
            
            int idx = 0;
            for (int x = i - 1; x < j; x++)
            {
                target[idx++] = array[x]; 
            }
            
            Array.Sort(target);
            
            answer[u] = target[k - 1];
        }
        
        return answer;
    }
}
