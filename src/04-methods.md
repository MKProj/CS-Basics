# Methods
Methods, functions, they're all the same thing, and in C# we follow the same declaration that you would see in languages like C, 
Java, C++, etc. Rather than giving you a list, I'll explain using a simple adding function and show the general format for methods.

```C#
int add(int a, int b)
{
    return a + b;
}
/*
We can see the following format:

<return type> <name> (<parameters>)
{
    return <data with return type>
}
*/
```
Now do keep in mind that there is also one extra return type seperate than the regular data types, 
we use this in our `Main` method, and that's the `void` return type. The `void` return type, well it 
doesn't return anything, and this is useful for printing something, or do some type of computation without 
requiring anything to return.

To invoke a method, it is very simple: 
```C#
int add(int a, int b)
{
    return a + b;
}

void Main()
{
    int sum = add(5,6);
    Console.WriteLn($"The sum is {sum}");
} 
```

### Optional Parameters 
Let's say we wanted option parameters, which are essentially parameters with default values. This is really easy to 
implement in C# and all we need to do is assign the parameter a default value: 

```C#
int add(int a, int b=8)
{
    return a + b;
}
```
Now this time if we use this add method and we do not place anything for b, it is then defaulted with the value of 8. 

### Out Parameters
Let's say we wanted to instead of returning a single value, wanted to return multiple, well we could instead use `out` parameters.
For these type of methods, you should use a `void` return type, since out parameters essentially set the parameters value. 

```C#
void set_colors(out string c1, out string c2)
{
    c1 = "Red";
    c2 = "Blue";
}
```

### Expression-Bodied Method
An expression-bodied method is a way to write a short method in oneline, and has the general syntax: 
`<return_type> <name>(<parameters>) => <expression>;` So we can rewrite our `add` method in a simple 
one line: 

```C#
//Original
int add(int a, int b)
{
    return a + b;
}
//Expression-Bodied version
int add(int a, int b) => a + b;
```