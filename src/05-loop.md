# Arrays & Loops
In this section we will first talk about Arrays and then Loops. Before we talk about declaring 
and initializing arrays, what is an array? Well the simplest explanation is: _A collection of a data_, and 
like other languages an array is a collection of data of a __single__ data type. 


### Declaring Arrays 
To declare an array, we follow the general syntax of `<data_type>[] name = new <data_type>[];`. 
We can decide to create an empty array, a specified length, or declare & initialize. To explain this better,
why don't we show all of these types in code: 

```C#
//New empty array
int[] numbers = new int[]; 

//New array with a length of 10
int[] numbers = new int[10];

//New array initialized 
int[] numbers = new int[]{12,34,5,7,9};
```

### Accessing Elements in Arrays 
The data inside an array are referred to as elements, and to access them we need to specify
their index. In collections for all languages, the index starts at 0, and goes forward from there. 

```C#
//Let's revisit our numbers array 
int[] numbers = new int[]{12,34,5,7,9};

Console.WriteLine($"The index of 0 has value: {numbers[0]}")
//Prints 12
Console.WriteLine($"The index of 2 has value: {numbers[2]}")
//Prints 5
```
We will talk about loops next, and how it extends our use with arrays. 

<!--
- while loops
    - infinite loops
- do while loops

- for loops
- foreach loops

- jump statements 

-->

