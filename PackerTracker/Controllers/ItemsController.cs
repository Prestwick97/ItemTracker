using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string name, bool packed, int price, bool purchased, int weight)
    {
      Item myItem = new Item(name, packed, price, purchased, weight);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]
      public ActionResult DeleteAll()
      {
        Item.ClearAll();
        return View();
      }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }
      
    [HttpPost("/items/{id}/deleteitem")]
    public ActionResult Destroy(int id)
    {
      Item.DeleteItem(id);
      return RedirectToAction("Index");
    }
    

  }

}