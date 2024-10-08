## 비선형자료구조

#### 트리
- 계층적 구조를 갖는 데이터를 표현하기 위한 자료구조
- Node(노드): 데이터를 표현 / Edge(간선): 노드의 계층 구조를 표현하기 위해 사용한다.

#### 이진 검색 트리
- 검색 트리: 연결 리스트, 큐와 같이 자료를 담는 컨테이너지만 일정한 순서에 따라 정렬한 상태로 저장한다.
- 이진 검색 트리: 각 노드가 최대 두 개의 자식 노드를 가지는 트리 (이진 탐색 아이디어 착안)
- 왼쪽: 현재 값보다 작음 / 오른쪽: 현재 값보다 큼

#### 힙 트리
- 부모 노드가 가진 값은 항상 자식 노드가 가진 값보다 큼 (이 규칙을 만족하도록 구성된 이진 트리) -> 힙의 대소 관계 규칙
- 이 규칙은 부모 자식 관계에만 적용되며, 왼쪽과 오른쪽 자식 간 원소 크기는 제한하지 않는다.
- 구조: 마지막 레벨을 제외한 모든 레벨에 노드가 꽉 차 있고 마지막 레벨에 노드가 있을 때 항상 왼쪽부터 순서대로 채워야 한다.
- 따라서 노드 개수를 알면 트리 구조는 무조건 확정할 수 있다.
- 배열로 표현하자면 -> i번 노드 왼쪽 자식 [(2*i) + 1]번, i번 노드 오른쪽 자식 [(2*i) + 2]번, i번 노드 부모 [(i-1) /2]번

#### 우선순위 큐
- 일반적인 큐와 달리 우선순위를 부여하여 순위가 높은 요소가 먼저 처리되는 구조이다.
- 힙 트리 원리를 사용하여 Push, Pop을 구현할 때 비교하여 순위를 설정할 수 있다.
- Push, Pop -> O(logN) 쉽게 생각해보면 각 층마다 한 번씩 비교를 하는데 N이 커져도 층은 요소가 2배씩 늘어나므로 생각보다 비교 횟수가 적다. (당연히 수학적으로 증명이 되어 있음)
- C# PriorityQueue<> 이용해서 사용 가능하다.

#### 그래프
- 트리와 같은 계층 구조보다 좀 더 일반적이고 강력한 자료구조
- 현실 세계의 사물이나 추상적인 개념 간의 연결 관계를 표현한다. ex) 도로망, 지하철 노선도 등
- Vertex(정점), Edge(간선) 구성된 자료구조
- 방향, 무방향, 순환, 비순환, 가중치 등 여러 방법 사용 가능하다.
