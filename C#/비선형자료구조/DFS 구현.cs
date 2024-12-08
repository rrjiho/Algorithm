// DFS (Depth First Search 깊이 우선 탐색)
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

    List<int>[] adj2 = new List<int>[]
    {
        new List<int>() { 1, 3 },
        new List<int>() { 0, 2, 3 },
        new List<int>() { 1 },
        new List<int>() { 0, 1, 4 },
        new List<int>() { 3, 5 },
        new List<int>() { 4 },
    };

    bool [] visited = new bool[6];
    // 1. now로 시작하고
    // 2. now와 연결된 정점을 하나씩 확인해서, 아직 미방문 상태라면 방문한다.
    public void DFS(int now)
    {
        Console.WriteLine(now);
        visited[now] = true; // now 부터 방문하고

        for (int next = 0; next < adj.GetLength(0); next++)
        {
            if (adj[now, next] == 0) // 연결되어 있지 않으면 스킵.
                continue;
            if (visited[next]) // 이미 방문했으면 스킵.
                continue;
            DFS(next);

        }
    }

    public void DFS2(int now)
    {
        Console.WriteLine(now);
        visited[now] = true; // now부터 방문하고

        foreach (int next in adj2[now])
        {
            if (visited[next]) // 이미 방문했으면 스킵.
                continue;
            DFS2(next);
        }
    }

    public void SearchAll() // 모든 정점을 순회 (노드가 끊어져 있는 경우)
    {
        visited = new bool[6];
        for (int now = 0; now < 6; now++) // list 버전도 실험해야 해서 now < 6;
        {
            if (visited[now] == false)
                DFS(now);
        }
    }
}
