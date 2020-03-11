using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Name {get; set;}
    public bool Packed {get; set;}
    public int Price {get; set;}
    public bool Purchased {get; set;}
    public int Weight {get; set;}
    public int Id {get;}
    private static List<Item> _instances = new List<Item> {};

    public Item(string name, bool packed, int price, bool purchased, int weight)
    {
      Name = name;
      Packed = packed;
      Price = price;
      Purchased = purchased;
      Weight = weight;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static void DeleteItem(int index)
    {
      _instances.Remove(_instances[index-1]);
      // Item.Id = _instances.Count;
    }    

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }

}