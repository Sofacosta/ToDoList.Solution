using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList 
{
  public class Program
  {
    public static void Main()
    {
      bool isGameRunning = true;
       List<Item> newList = new List<Item> {};
      while (isGameRunning) {
      Console.WriteLine("Write a quick description of the item you would like to add to your list.");
      string description = System.Console.ReadLine();
      Item newItem = new Item(description);
     
      newList.Add(newItem);
  
    
      foreach (Item task in newList)
      {
        Console.WriteLine(task.Description);
      }
      }

    }
  }
}