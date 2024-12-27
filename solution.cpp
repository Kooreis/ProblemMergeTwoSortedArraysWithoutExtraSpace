```cpp
#include <iostream>
#include <algorithm>

void merge(int arr1[], int arr2[], int n, int m) {
    for (int i = 0; i < n; i++) {
        if (arr1[i] > arr2[0]) {
            std::swap(arr1[i], arr2[0]);
            int first = arr2[0];
            int k;
            for (k = 1; k < m && arr2[k] < first; k++) {
                arr2[k - 1] = arr2[k];
            }
            arr2[k - 1] = first;
        }
    }
}

int main() {
    int arr1[] = {1, 5, 9, 10, 15, 20};
    int arr2[] = {2, 3, 8, 13};
    int n = sizeof(arr1) / sizeof(arr1[0]);
    int m = sizeof(arr2) / sizeof(arr2[0]);
    merge(arr1, arr2, n, m);
    std::cout << "After Merging \nFirst Array: ";
    for (int i = 0; i < n; i++)
        std::cout << arr1[i] << " ";
    std::cout << "\nSecond Array: ";
    for (int i = 0; i < m; i++)
        std::cout << arr2[i] << " ";
    return 0;
}
```