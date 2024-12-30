# Question: How do you merge two sorted arrays into one sorted array without extra space? JavaScript Summary

The JavaScript code provided defines a function named `mergeArrays` that merges two sorted arrays into a single sorted array. The function takes two sorted arrays as arguments, `arr1` and `arr2`. It uses three counters `i`, `j`, and `k` to keep track of the current index in `arr1`, `arr2`, and the resulting array `arr3` respectively. The function then enters a loop that continues until it has iterated through all elements in both `arr1` and `arr2`. In each iteration, it compares the current elements of `arr1` and `arr2`, and adds the smaller one to `arr3`, incrementing the respective counter. If all elements from one array have been added to `arr3`, the remaining elements from the other array are added to `arr3` in subsequent loops. The function then returns `arr3`, which is a sorted array that contains all elements from `arr1` and `arr2`. The script concludes by calling `mergeArrays` with two example arrays and logging the result to the console.

---

# TypeScript Differences

The TypeScript solution is different from the JavaScript solution in several ways:

1. Use of Classes: The TypeScript solution uses a class `MergeSortedArrays` to encapsulate the `mergeArrays` method. This is a feature of TypeScript that allows for better organization and encapsulation of related functions and data.

2. Type Annotations: TypeScript allows for type annotations, which can help catch errors at compile time. In the TypeScript solution, the `mergeArrays` method has type annotations for its parameters and return type, specifying that they should be arrays of numbers.

3. Use of Spread Operator: The TypeScript solution uses the spread operator (`...`) to combine the two input arrays into one. This is a more concise way to merge arrays compared to the JavaScript solution, which uses a while loop to manually add each element from the input arrays to the result array.

4. Use of Array.sort(): The TypeScript solution uses the `Array.sort()` method to sort the combined array. This is a built-in JavaScript method that sorts the elements of an array in place and returns the array. The JavaScript solution, on the other hand, sorts the arrays manually using a while loop.

5. Extra Space: The TypeScript solution does not meet the requirement of the problem to merge the arrays without extra space. It creates a new array to hold the merged and sorted elements, whereas the JavaScript solution merges the arrays in place.

In conclusion, the TypeScript solution is more concise and easier to read, but it does not meet the problem's requirement of merging the arrays without using extra space. The JavaScript solution, while more verbose, meets all the requirements of the problem.

---

# C++ Differences

The C++ version of the solution solves the problem differently than the JavaScript version. Instead of creating a new array to store the merged result, it merges the second array into the first one in-place, thus not using any extra space. This is in line with the problem statement which asks for a solution without extra space.

The C++ solution iterates over the first array and for each element, it checks if it is greater than the first element of the second array. If it is, it swaps the two elements and then reorders the second array to ensure it remains sorted. This process continues until all elements in the first array have been checked.

The C++ solution uses the `std::swap` function from the `<algorithm>` library to swap elements, which is not available in JavaScript. It also uses the `sizeof` operator to determine the length of the arrays, which is also not available in JavaScript. In JavaScript, the length of an array is accessed using the `.length` property.

In terms of output, the JavaScript version returns a new array that is the result of merging the two input arrays, while the C++ version modifies the input arrays in-place and does not return anything. Instead, it prints the contents of the two arrays after merging.

In terms of language features, C++ allows passing arrays to functions by reference, which means the function can modify the original arrays. JavaScript, on the other hand, passes arrays to functions by value, which means a copy of the array is created and the original array cannot be modified by the function. However, since arrays in JavaScript are objects and objects are actually passed by reference, changes to the elements of the array inside the function do reflect outside the function.

---
