// 연결 리스트만 지원하더라도 스택, 큐로 사용이 가능함
// 따라서 표준 라이브러리를 사용하여 효율적으로 사용
// 모두 O(1) 상수 시간에 이루어짐

Stack<int> stack = new Stack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);

int data = stack.Pop();
int data2 = stack.Peek();

Queue<int> queue = new Queue<int>();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

int data3 = queue.Dequeue();
int data4 = queue.Peek();
