// BFS (Breadth First Search 너비 우선 탐색)
class Graph
{
    int[,] adj = new int[6, 6]
    {
        { 0, 1, 0, 1, 0, 0 },
        { 1, 0, 1, 1, 0, 0 },
        { 0, 1, 0, 0, 0, 0 },
        { 1, 1, 0, 0, 1, 0 },
        { 0, 1, 0, 1, 0, 1 },
        { 0, 0, 0, 0, 1, 0 },
    };
  
    public void BFS(int start)
    {
        bool[] found = new bool[6];
        int[] parent = new int[6]; // 이렇게 응용도 가능함
        int[] distance = new int[6];

        Queue<int> q = new Queue<int>(); // 인접한 것을 발견 순서대로 예약한다는 것
        q.Enqueue(start);
        found[start] = true;
        parent[start] = start;
        distance[start] = 0;


        while (q.Count > 0)
        {
            int now = q.Dequeue();
            Console.WriteLine(now);

            for (int next = 0; next < 6; next++)
            {
                if (adj[now, next] == 0)
                    continue;
                if (found[next])
                    continue;
                q.Enqueue(next);
                found[next] = true;
                parent[next] = now;
                distance[next] = distance[now] + 1;
            }
        }
    }
    
}
