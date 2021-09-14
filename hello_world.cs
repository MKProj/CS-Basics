using System;
public class Program{
    static void Main(){
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
    }
}