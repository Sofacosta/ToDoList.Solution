using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    // properties, methods, etc. will go here.
    public string Description {get; set;}
    private static ToDoList<Item> _instances = new List<Item> {};
    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
  }
}