# Introduction

C# was initially developed by Microsoft as part of it's .NET initiative. For related context, 
C# has been used in various frameworks to build game engines (Unity), mobile apps (Xamarin.Forms),
web apps (ASP.NET), and is all managed by the .NET Foundation. Even the [MKProject](https://www.mkproj.com) website is 
made with the ASP.NET Blazor WebAssembly framework to build fast, dynamic and responsive websites. 

C# from how I describe it, feels like a better Java, not like Kotlin, but in the essence that their syntax is pretty much 
the same, but C# requires less typing, and just feels a lot smoother. This may not be everyone's experience or first thoughts, but 
this is how I felt learning C# after my Java ICS Class. 

## Program Structure 
Let's create a `hello_world.cs` program, and make it just print `Hello World!`:

```C#
using System;
public class Hello_World{
        static void Main(){
            Console.WriteLine("Hello World!");
        } 
}
```

Let's go through this line by line: 
1. `using System`: This imports the necessary libraries to interact with your system, 
such as read and writing data from a terminal.
2.  `public class Hello_World`: This is similar to Java, where a Main method must reside in a class, 
and its a good idea to name it the same as the file or project name. 
3. `static void Main()`: This is the method where all code is to be executed by the program
4. `Console.WriteLine("Hello World!")`: This method that is used to display data to the terminal.

Now let's run our program, in this book we will use Powershell:
```PowerShell
> csc hello_world.cs
> ./hello_world.exe
Hello World!
```