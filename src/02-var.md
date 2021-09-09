# Data Types & Variables

Just like other languages such as Java, C++, C, you must declare the data type before the variable name. 
In C# we have these common data type: 

- `string` : A collection of characters 
- `char` : A single character 
- `int` : A signed integer
- `double` : A double point float number (decimal number)
- `bool` : Either true or false 

We can declare each of these data types like the following: 

```C#
string str = "Hello World";
char c = "c";
int i = 12;
double d = 43.56;
bool b = false;
```

Notice that when initializing variables, we first declare the data type (such as `int`), 
following a name (`i` in this example), then it follows an assignment operator (`=`) with 
a value corresponding to the type.

If we do not know the value of the variable immediately, then we may leave it uninitialized such as 
`string str;`. Since we know the basics of variables, let's use it to our advantage. 

## Let's find the character!!!
This is a simple program that will take a string from the user, and we will try to find the location 
of a character (`w` for our example) and print that out. 

```C#
using System;
public class Program{
    static void Main(){
        Console.WriteLine("Enter phrase: ");
        // To read input, use Console.ReadLine
        string input = Console.ReadLine();
        // Finds the index of a character w
        int index = input.IndexOf('w');
        Console.WriteLine($"The index of w in {input} is {index}");
    }
}
```

```PowerShell
> csc main.cs
> ./main.exe 
Enter phrase:
winner
The index of w in winner is 0
```

## Comments
The last thing to talk about is comments, in C# we have two type of comments, 
single line (`//`) and multi-line (`/* */`). Comments can be used a temporary 
way to debug or to document your code, as can be seen in the example above, it is 
always important to try and document your code. 

Comments are useful to use when you're coding so you don't forget what that random 
variable is, and it's always ignored by the compiler. 
```C#
// This is used to talk in one line

/*

This is used to 
talk in multiple lines

yap yap yap
*/
````