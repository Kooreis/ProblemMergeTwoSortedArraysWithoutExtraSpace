Here is a JavaScript solution for the problem:

```javascript
function mergeArrays(arr1, arr2) {
    let i = 0;
    let j = 0;
    let k = 0;
    let arr3 = [];

    while (i < arr1.length && j < arr2.length) {
        if (arr1[i] < arr2[j]) {
            arr3[k] = arr1[i];
            i++;
        } else {
            arr3[k] = arr2[j];
            j++;
        }
        k++;
    }

    while (i < arr1.length) {
        arr3[k] = arr1[i];
        i++;
        k++;
    }

    while (j < arr2.length) {
        arr3[k] = arr2[j];
        j++;
        k++;
    }

    return arr3;
}

console.log(mergeArrays([1, 3, 5], [2, 4, 6]));
```

This script defines a function `mergeArrays` that takes two sorted arrays as input, merges them into a single sorted array, and returns the result. The function uses three pointers to track the current position in each array. It compares the current elements of the input arrays and adds the smaller one to the result array. If one of the input arrays is exhausted, it adds the remaining elements of the other array to the result. The script then calls this function with two example arrays and logs the result to the console.