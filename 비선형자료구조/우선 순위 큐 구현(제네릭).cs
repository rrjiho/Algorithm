class PriorityQueue<T> where T : IComparable<T>
{
    List<T> _heap = new List<T>();
    
    // O(LogN)
    public void Push(T data)
    {
        // 힙의 맨 끝에 새로운 데이터 삽입
        _heap.Add(data);

        int now = _heap.Count - 1;
        // 비교 시작
        while (now > 0)
        {
            // 부모와 비교
            int next = (now - 1) / 2;
            if (_heap[now].CompareTo( _heap[next]) < 0) // 실패
                break;

            // 성공하면 교체
            T temp = _heap[now];
            _heap[now] = _heap[next];
            _heap[next] = temp;

            // 위치 변경
            now = next;
        }
    }

    // O(LogN)
    public T Pop()
    {
        // 반환할 데이터를 따로 저장
        T ret = _heap[0];

        // 마지막 데이터를 루트로 이동시킴
        int lastIndex = _heap.Count - 1;
        _heap[0] = _heap[lastIndex];
        _heap.RemoveAt(lastIndex);
        lastIndex--;

        // 비교해서 밑으로 내려감
        int now = 0;
        while (true)
        {
            int left = 2 * now + 1;
            int right = 2 * now + 2;

            int next = now;
            // 왼쪽 값이 현재 값보다 크면, 왼쪽으로 이동
            if (left <= lastIndex && _heap[next].CompareTo(_heap[left]) < 0)
                next = left;
            // 오른쪽 값이 현재 값(왼쪽 이동을 포함)보다 크면, 오른쪽으로 이동
            if (right <= lastIndex && _heap[next].CompareTo(_heap[right]) < 0)
                next = right;

            // 왼쪽, 오른쪽 모두 현재 값보다 작으면 종료
            if (next == now)
                break;

            // 두 값을 교체
            T temp = _heap[now];
            _heap[now] = _heap[next];
            _heap[next] = temp;

            // 비교 위치를 이동
            now = next;

        }

        return ret;
    }

    public int Count()
    {
        return _heap.Count; 
    }      
}
