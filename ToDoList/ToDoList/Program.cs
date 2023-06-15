﻿
Console.WriteLine("Hello!");
string userInput;
var toDoList = new List<string>();

do
{
    Console.WriteLine("\n\n");
    Console.WriteLine("Whats do you want to do?");
    Console.WriteLine("[S]ee all TODOs.");
    Console.WriteLine("[A]dd a TODO.");
    Console.WriteLine("[R]emove a TODO.");
    Console.WriteLine("[E]xit.");
    Console.Write("Enter : ");
    userInput = Console.ReadLine();

    if (userInput.ToUpper() == "S")
    {
        SeeAllToDo(toDoList);
    }
    else if (userInput.ToUpper() == "A")
    {
        AddToDos(toDoList);
    }
    else if (userInput.ToUpper() == "R")
    {
        Console.WriteLine(userInput);
    }
    else if (userInput.ToUpper() == "E")
    {
        Console.WriteLine(userInput);
    }
    else
    {
        Console.WriteLine("Invalid Choice!");
    }

} while (userInput.ToUpper() != "E");

Console.ReadLine();
void SeeAllToDo(List<string> list)
{
    foreach (string item in list)
    {
        list.IndexOf(item);
        Console.WriteLine($"{list.IndexOf(item)+1}. {item}");
    }
}
List<string> AddToDos(List<string> list)
{
    while (true)
    {
        Console.WriteLine("Enter the TODO description: ");
        string inputToDo = Console.ReadLine();
        if (list.Contains(inputToDo))
        {
            Console.WriteLine("The description must be unique. \n");
        }
        else if (string.IsNullOrWhiteSpace(inputToDo))
        {
            Console.WriteLine("The description cannot be empty.\n");
        }
        else
        {
            list.Add(inputToDo);
            Console.WriteLine("TODO successfully added : " + inputToDo);
            Console.WriteLine("\n");
            return list;
        }
    };
    return list;
}

