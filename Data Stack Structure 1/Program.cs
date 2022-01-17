using System;
using System.Collections.Generic;

namespace Data_Stack_Structure_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defines the main variables that will be used within the runtime of the program
            Stack<int> Numbers = new Stack<int>(); //Defines a new Stack<int> variable called 'Numbers'

            //Push - Inserts an object at the top of the stack

            Console.WriteLine("Pushing numbers 5 & 9 to the stack");
            Numbers.Push(5); //Adds the integer '5' to the top of the Stack 'Numbers'
            Numbers.Push(9); //Adds the integer '9' to the top of the Stack 'Numbers'

            Console.WriteLine(); //Empty WritLine command to make the console look neater 

            //Pop - Returns and removes the object at the top of the 
            Console.WriteLine("Using the Peek() method");
            Console.WriteLine(Numbers.Pop());

            Console.WriteLine(); //Empty WritLine command to make the console look neater 

            //Peek - Returns the object at the top of the stack without removing it
            Console.WriteLine("Using the Pop() method");
            Console.WriteLine(Numbers.Peek());
        }
    }
}
