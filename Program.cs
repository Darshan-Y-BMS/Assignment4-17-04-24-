using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

//Exercise 1: List Exercise
//Create a program to manage a list of names. Implement the following functionalities:
//•	Add new names to the list.
//•	Display all names in the list.
//•	Remove a name from the list by its index.
//•	Update a name in the list by its index.
void ListExercise()
{
    //??why IList doesnot has add range
    List<string> names = new List<string>();

    names.Add("Rama");
    names.Add("Lakshmana");
    string[] names2 = { "Bhratha", "Shatrughna" };
    names.AddRange(names2);

    Console.WriteLine("\nDisplay all names in the list.");
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }

    Console.WriteLine("\nRemove a name from the list by its index.");
    names.Remove(names[2]);
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }

    Console.WriteLine("\nUpdate a name in the list by its index.");
    names[0] = "Shree Rama";
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}

//Exercise 2: Dictionary Exercise
//Develop a program to manage a dictionary of words and their meanings.
//Implement the following functionalities:
//•	Add new words and their meanings to the dictionary.
//•	Display all words and their meanings.
//•	Search for the meaning of a specific word.
//•	Remove a word from the dictionary.
void DictExercise()
{
    Dictionary<string,string> dict = new Dictionary<string,string>();
    //           ^       ^
    //         word  meaning

    dict.Add("Brave","Courageous");
    dict.Add("Beautiful","Gorgeous");
    dict.Add("Begin", "Start");
    dict.Add("Big", "Enormous");

    Console.WriteLine("\nDisplay all words and their meanings.");
    Console.WriteLine("\nWORD         MEANING");
    foreach (string name in dict.Keys)
    {
        Console.WriteLine($"{name}        {dict[name]}");
    }

    //Search for the meaning of a specific word.
    Console.WriteLine("\nSearch for the meaning of a specific word.");
    string result = dict.GetValueOrDefault("Big", "Word meaning not found");
    Console.WriteLine("WORD : Big");
    Console.WriteLine(result);
    result = dict.GetValueOrDefault("Small", "Word meaning not found");
    Console.WriteLine("WORD : Small");
    Console.WriteLine(result);

    //Remove a word from the dictionary.
    dict.Remove("Big");
    Console.WriteLine("\nAfter Removing 'Big'");
    Console.WriteLine("\nWORD         MEANING");
    foreach (string name in dict.Keys)
    {
        Console.WriteLine($"{name}        {dict[name]}");
    }
}

//Exercise 3: Queue Exercise
//Simulate a queue management system for a store.
//Each customer in the queue should have a name.
//Implement the following functionalities:
//•	Add new customers to the queue.
//•	Serve the next customer in the queue (remove them from the queue).
//•	Display the current number of customers in the queue.
//•	Clear the entire queue.

void QueueExercise()
{
    Queue<string> customer = new Queue<string>();
    customer.Enqueue("Bhaskara");
    customer.Enqueue("Arya");
    customer.Enqueue("Charraka");

    string NextCustomer = customer.Dequeue();
    Console.WriteLine("\nNext Customer is " + NextCustomer);

    Console.WriteLine("Current number of customer is " + customer.Count());

    customer.Clear();

}

//4. Stack Exercise
//Design a program to manage a stack of integers representing numbers.
//Implement the following functionalities:
//•	Push new numbers onto the stack.
//•	Pop the top number from the stack.
//•	Display the top number without removing it.
//•	Check if the stack is empty.
void StackExercise()
{
    Stack<int>num = new Stack<int>();
    int[] n = { 7, 2, 3, 8, 9, 12 };

    foreach (int i in n)
    {
        num.Push(i);
    }

    int res = num.Pop();
    Console.WriteLine("Popped element "+res);

    Console.WriteLine("Peek   element "+num.Pop());

    Console.WriteLine("Status does stack contains elements" + num.Any());
}
//ListExercise();
//DictExercise();
//QueueExercise();
StackExercise();



