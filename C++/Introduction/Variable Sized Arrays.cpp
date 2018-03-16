#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main() {
    int n;
    int q;
    cin >> n >> q;
    
    int** arr = new int*[n];
    for(int i=0; i<n; i++)
    {
        int index;
        cin >> index;
        arr[i] = new int[index];
        for(int j=0; j<index; j++) cin >> arr[i][j];
    }
    
    for(int i=0; i<q; i++)
    {
        int a;
        int b;
        cin >> a >> b;
        cout << arr[a][b] << endl;
    }
    return 0;
}