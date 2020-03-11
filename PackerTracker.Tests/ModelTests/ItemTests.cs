using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests 
  {
    // public void Dispose()
    // {
    //   Item.ClearAll();
    // }

    [TestMethod]
    public void ItemConstructor_CreateInstanceOfItem_Item()
    {
      Item newItem = new Item("item");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }


  }
}