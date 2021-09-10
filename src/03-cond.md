# Conditionals

When we want to ask if a condition is met I want this to happen, how do we translate that to C#? 
For those coming from other languages will probably answer, well `if/else` statements and that's one way!

Before we go in further let's look at Logic and Conditional operators: 

- `&&` : AND operator, if both statements are  `true` then it results `true`. 
- `||` : OR operator, if one statement is `true`, then it results `true`. 
- `!` : NOT operator, inverses the statement, `!true == false`

- `==` : Equals operator, it will look if both statements on each side equate
- `>` : Greater than operator, it will check if Left is greater than Right 
- `<` : Less than operator, it will check if Left is less than Right
- `>=` : Greater than or equal operator, it will check if Left is greater than or equal to Right. 
- `<=` :  Less than or equal operator, it will check if Left is less than or equal to Right

## If/Else Statements 
An `if` statement executes a block of code if the condition met is true, an `else` statement
executes a block of code if the condition met is false. To see this more in action, let's look
at a simple example: 


```C#
if(5 > 6)
{
    Console.WriteLine("This is true");
} else 
{
    Console.WriteLine("This is false");
}
```
If we run this, we would get the result of `This is false!`, 5 is not greater than 6! However what if we also wanted to check if 5 is greater 
than 4? Would we have to add another if statement? Of course not, we would instead add an `else if` statement, which is executed if the condition
is true. Let's update our little program here then, 

```C#
if(5 > 6)
{
    Console.WriteLine("This is true!");
} else if(5 > 4)
{
    Console.WriteLine("This is also true!");
} else 
{
    Console.WriteLine("This is false!");
}
```
Now if we run this, we would get the result of `This is also true!`, as 5 is indeed greater than 4. 


## Switch Statements 
Now `if/else` statement tend to get really messy when you have many different conditions you're checking, so 
you may also use a `switch` statement which is similar to how C uses it. Switch statement can make your 
code look more readable as long as you know what cases you'd like to handle. Another thing you must use 
with switch statments is the `break` statement that will exit the switch statement once the condition is met, and 
it's block of code is executed. 

In this example we will be checking for (may be a bit nerdy) preferred GPU Manufacturer: 

```C#
//Intel is by the way bringing a new gpu 
string pref_gpu = "AMD";

switch(pref_gpu){
    //to handle a case, use case <condition>: 
    case "AMD" : 
        Console.WriteLine("Welcome Team Red!");
        break;
    case "Intel" : 
        Console.WriteLine("Coming soon...Team Blue");
        break;
    case "Nvidia":
        Console.WriteLine("Welcome Team Green!");
        break;
}
```
If we run this program, we would be greeted with `Welcome to Team Red!`, with funny enough 
hypocrisy as I run all Intel hardware (for now!). 


## Ternary Operator
All the options we have are great and all, but let's say we want to do an if/else statement in one line? How would we do that?
We could use the ternary operator, however note that this is only useful when a variable's value depends on different conditions!

- The ternary operator works as the following: `<condition> ? <true> : <false>;`

Let's see a simple example deciding what to do when I'm hungry. 
```C#
bool imHungry = true;

string what_to_do = imHungry ? "Go to McDonald's" : "Go Home and sleep";
```