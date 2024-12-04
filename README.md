# Data Inconsistency in C# Property Access and Modification

This example highlights a subtle concurrency issue that can arise when reading and writing a property within the same class's method. While this scenario is less common in single-threaded applications, it becomes significant in multithreaded environments.  The code demonstrates how inconsistent data might result if another thread alters the property's value between the get and set operations.

## How to reproduce:

1. Clone this repository.
2. Compile and run the `Bug.cs` file.
3. Note the inconsistency of the expected and actual value of the variable. 
4. Examine the `BugSolution.cs` file for a possible solution. 

## Solution:

To resolve the problem, you must protect the property access and modification using thread safety mechanisms such as locks (using `lock` statement in C#).