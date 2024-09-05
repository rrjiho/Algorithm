class MyList<T>
{
    const int DEFAULT_SIZE = 1;
    T[] _data = new T[DEFAULT_SIZE];

    public int Count = 0; // 실제 사용중인 데이터 개수
    public int Capacity { get { return _data.Length; } } // 예약된 데이터 개수

    // O(1): 공간 늘리는 것은 아주 가끔 발생하는 일로써 무시할 수 있는 수준(N) 따라서 상수 시간
    public void Add(T item)
    {
        // 1. 공간이 충분히 남아 있는지 확인함
        if(Count >= Capacity)
        {
            // 공간을 늘려서 확보
            T[] newArray = new T[Count * 2];
            for (int i = 0; i < Count; i++)
                newArray[i] = _data[i];
            _data = newArray;
        }

        // 2. 공간에 데이터를 넣어줌
        _data[Count] = item;
        Count++;
    }

    // O(1)
    public T this[int index]
    {
        get { return _data[index]; }
        set { _data[index] = value; }
    }

    // O(N)
    public void RemoveAt(int index)
    {
        for (int i = index; i < Count - 1; i++)
            _data[i] = _data[i + 1];
        _data[Count - 1] = default(T); // 값 -> 0, 참조 -> null 반환

        Count--;
    }
}
