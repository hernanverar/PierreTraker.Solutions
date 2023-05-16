using System.Collections.Generic;

namespace PierreTraker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public int Id { get; }
    public string V1 { get; }
    public int V2 { get; }
    public string V3 { get; }

    private static List<Order> _instances = new List<Order> { };

    public Order(string title, string v1, int v2, string v3)
    {
      Title = title;
      V1 = v1;
      V2 = v2;
      V3 = v3;
    }
  }
  public Order(string title, string description, float price)
  {
    Title = title;
    Description = description;
    Price = price;
    _instances.Add(this);
    Id = _instances.Count;
  }
  public static List<Order> GetAll()
  {
    return _instances;
  }
  public static void ClearAll()
  {
    _instances.Clear();
  }
  public static Order Find(int searchId)
  {
    return _instances[searchId - 1];
  }
}