#include <iostream>

using namespace std;

/*int MySwap(int i, int j)
{
    int temp = i;
    i = j;
    j = temp;

    return ? 하나의 값만 리턴할 수 있기 때문에 다른 방법이 필요함
}
*/

void MySwapPtr(int* i, int* j)
{
    int temp = *i;
    *i = *j;
    *j = temp;
}

void MySwapRef(int& i, int& j)
{
    int temp = i;
    i = j;
    j = temp;
    // 참조로 받을 시 포인터로 받을 때 처럼 여러 과정을 거치지 않아도 되므로 편리함
}

bool CheckSorted(int a, int b)
{
    if (a <= b) return true;
    else return false;
}

int main()
{
    // 교환(Swap)
    { 
        int a = 3;
        int b = 2;

        cout << a << " " << b << endl;

        //MySwapPtr(&a, &b);
        //MySwapRef(a, b);
        cout << a << " " << b << endl;
    }

    // 정렬(sorting)
    {
        int arr[] = { 3, 2 };

        cout << arr[0] << " " << arr[1] << endl;


        cout << arr[0] << " " << arr[1] << endl;
    }

    // 비교 정렬 프로그램
    {
        int arr[2];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                arr[0] = i;
                arr[1] = j;

                if (arr[0] > arr[1])
                    swap(arr[0], arr[1]);

                cout << boolalpha;
                cout << arr[0] << " " << arr[1] << " "
                    << CheckSorted(arr[0], arr[1]) << endl;
            }
        }
    }
    return 0;
}
