#include <iostream>

using namespace std;

int main()
{
    int n,k;
    cin >> n >> k;
    int sum = 0;
    int Max = 0;
    int i=1;
    while(n--)
    {
        int a;
        cin >> a;
        if(a > 8)
        {
            Max += a-8;
            sum += 8;
        }
        else
        {
            if(Max + a >= 8)
            {
                sum += 8;
                Max += a-8;
            }
            else
            {
                sum += Max + a;
                Max = 0;
            }
        }

        if(sum >= k)
        {
            cout<<i;
            return 0;
        }
        ++i;
    }
    cout<<-1;
    return 0;
}
