namespace Kata {
  public class Item {
    public Item() {}
    public Item(string name) { Name = name; }

    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
  }
}
