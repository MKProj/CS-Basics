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


## While Loops 
While loops executed a block of code repeatedly until it's condition is false, and this can be used
to iterate through an array, printing a pattern, etc. To show this better let's show a simple loop 
that prints all the array's element: 

```C#
int i = 0; //Counter 
int[] numbers = new int[]{89,45,6,8,12};
// while(condition){}
//This will loop until i is greater than the array's length
while(i < numbers.Length)
{
    Console.WriteLine("The index {0} has element {1}", i, numbers[i]);
    //formatted string {index}
    i++; 
    //Increases i by 1
}
```

A warning of while loops are infinite loops, and this is when the condition is always true, 
such that `while(true)` will cause the application, or even in one case for me, my whole computer crashed. 
They should not be taken lightly, and should be avoided in usage. 

### Do-While loops 
A do-while loop is a loop where the block of code will at least execute once even if the condition is false. 
```C#
int i = 0;
do{
    Console.WriteLine("{0}", i);
    i++;
} while(i < 5);

//This is the same as:
int i = 0;
Console.WriteLine("{0}", i);
i++;
while(i < 5)
{
    Console.WriteLine("{0}", i)
    i++;
}
```
This is useful when you want the code to at least execute once, and as 
you can see from the example, it also reduces the code repetition quite a bit.


## For Loops 
A for loop is usually the preferred way of iterating through arrays, or 
using loops in general. The for loop has three parameters: 
- `for(int i = 0; i < <number>; i++)`
    - `int i = 0` : This is the counter initilization
    - `i < <number>` : This is the stopping condition
    - `i++` : This is the iteration statement

To see this better, let's rewrite our iteration loop but instead of 
a while loop, let's use a for loop.

```C#
int[] numbers = new int[]{78, 56, 4,32,1};

for(int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("The index {0} has element {1}", i, numbers[i]);
}

```
Doesn't that look a lot better! Well we can step this up by using a simpler
version of a for loop called a foreach loop. 

### ForEach Loop 
In languages like Python & Rust, a foreach loop is the default for loop, and what they
all have in common is by using ranges. This is done by using the `in` keyword, and we can
see it being used in the example below:

```C#
int[] numbers = new int[]{12,34,5,6,8};

// foreach(<element> in <array>)
foreach(int num in numbers)
{
    Console.WriteLine("The element is {0}", num);
}
```





<!--

- jump statements 

-->

