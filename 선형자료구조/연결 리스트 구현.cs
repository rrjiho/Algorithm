// Node -> next, previous 연결 개념
// 만약 100만개 자료를 LinkedList로 만들었다면 50만 번째 자료를 찾기 위해서 50만번 검색을 해야 하니 선형 시간이 걸리게 됨 (참고)
class MyLinkedListNode<T>
{
    public T Data;
    public MyLinkedListNode<T> Next;
    public MyLinkedListNode<T> Prev;
}

class MyLinkedList<T>
{
    public MyLinkedListNode<T> Head = null;
    public MyLinkedListNode<T> Tail = null;
    public int Count = 0;

    // O(1)
    public MyLinkedListNode<T> AddLast(T data)
    {
        MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();
        newRoom.Data = data;

        // 방이 하나도 존재하지 않은 경우 추가된 방이 Head
        if (Head == null)
            Head = newRoom;

        // 마지막 방과 새로 추가된 방을 연결하고 
        if(Tail != null)
        {
            Tail.Next = newRoom;
            newRoom.Prev = Tail;
        }

        // 꼬리를 재설정함
        Tail = newRoom;
        Count++;
        return newRoom;
    }

    // O(1)
    public void Remove(MyLinkedListNode<T> room)
    {
        // Head 다음 방을 Head로 설정
        if(Head == room)
            Head = Head.Next;

        // Tail 이전 방을 Tail로 설정
        if(Tail == room)
            Tail = Tail.Prev;

        // 이전 방을 이후 방과 연결해줌
        if (room.Prev != null)
            room.Prev.Next = room.Next;

        // 이후 방을 이전 방과 연결해줌
        if (room.Next != null)
            room.Next.Prev = room.Prev;

        Count--;
    }
}
