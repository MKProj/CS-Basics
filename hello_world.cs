using System;
public class Program{
    static void Main(){
        Console.WriteLine("Enter phrase: ");
        // To read input, use Console.ReadLine
        string input = Console.ReadLine();
        // Finds the index of a character w
        int index = input.IndexOf('w');
        Console.WriteLine(index);
    }
}