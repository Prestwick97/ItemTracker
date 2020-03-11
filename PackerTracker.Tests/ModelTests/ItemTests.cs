using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreateInstanceOfItem_Item()
    {
      Item newItem = new Item("item", true, 54,true, 23);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    // [TestMethod]
    // public void ItemConstructor_ReturnsAllPropertyValues_Item()
    // {
  
    
    //   // Item actual = new ITem ("hello", true, 34, true, 2);
    //   result = newItem.name
    //   Assert.AreEqual(newItem, actual)
    // }

    [TestMethod]
      public void GetAll_ReturnsItems_ItemList()
      {
        string name = "hello";
        bool pack = true;
        int price = 34;
        bool purchased = true;
        int weight = 2;

        Item newItem = new Item(name, pack, price, purchased, weight);
       
        List<Item> newList = new List<Item> { newItem };
      
        List<Item> result = Item.GetAll();

        CollectionAssert.AreEqual(newList, result);
      }



  }
}