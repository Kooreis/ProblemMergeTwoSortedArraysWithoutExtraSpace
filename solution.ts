Here is a TypeScript solution for the problem:

```typescript
class MergeSortedArrays {
    mergeArrays(arr1: number[], arr2: number[]): number[] {
        let mergedArray = [...arr1, ...arr2];
        mergedArray.sort((a, b) => a - b);
        return mergedArray;
    }
}

let mergeSortedArrays = new MergeSortedArrays();
let arr1 = [1, 3, 5, 7];
let arr2 = [2, 4, 6, 8];
console.log(mergeSortedArrays.mergeArrays(arr1, arr2));
```

This solution uses the spread operator to combine the two arrays into one and then sorts the combined array. The sort function is passed a comparator function to ensure the numbers are sorted numerically. The sorted array is then returned.