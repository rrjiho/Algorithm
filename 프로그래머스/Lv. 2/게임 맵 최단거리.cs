using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {     
        int n = maps.GetLength(0);
        int m = maps.GetLength(1);
        
        int[] dx = {-1, 1, 0, 0};
        int[] dy = {0, 0, -1, 1};
        
        bool[,] visited = new bool[n, m];
        
        Queue<(int x, int y, int dist)> queue = new Queue<(int x, int y, int dist)>();
        queue.Enqueue((0, 0, 1));
        visited[0, 0] = true;
        
        while (queue.Count > 0)
        {
            var (x, y, dist) = queue.Dequeue();
            
            if (x == n - 1 && y == m - 1)
                return dist;
            
            for (int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];
                
                if (nx >= 0 && ny >= 0 && nx < n && ny < m && maps[nx, ny] == 1 && !visited[nx, ny])
                {
                    visited[nx, ny] = true;
                    queue.Enqueue((nx, ny, dist + 1));
                }
            }
        } // queue 성질 이용해서 모든 경로를 동시 다발적으로 퍼져서 확인한다고 생각하면 됨
          // 서버에서 다루는 길찾기 가장 기본이 되는 형태
        
        return -1;
    }
}
