using System;

public class Solution {
    public int solution(int n, int[,] computers) {
        bool[] visited = new bool[n];
        int networkCount = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                DFS(i, visited, computers, n);
                networkCount++;
            }
        }
        
        return networkCount;
    }
    
    public void DFS(int index, bool[] visited, int[,] computers, int n)
    {
        visited[index] = true;
        
        for (int i = 0; i < n; i++)
        {
            if (computers[index, i] == 1 && !visited[i])
            {
                DFS(i, visited, computers, n);
            }
        }// 방문 여부, 끊기면 DFS 빠져나와서 처음 반복문 진행 -> 방문 안 한것 있으면 다시 시작 count++
    }
}
