namespace Kata {
  public class Item {
    public static Item Update(Item item) {
      if (item.Name == N_.Sulfuras)
        return item;

      int qualityChange = -1;

      if (item.Name == N_.AgedBrie) {
        qualityChange = 1;
        
        if (item.SellIn < 1)
          qualityChange = 2;
      }

      if (item.Name == N_.ConcertTickets) {
        qualityChange = 1;

        if (item.SellIn < 11)
          qualityChange = 2;

        if (item.SellIn < 6)
          qualityChange = 3;

        if (item.SellIn < 1)
          qualityChange = -item.Quality;
      }

      item.Quality = item.Quality + qualityChange;
      item.SellIn = item.SellIn - 1;

      if (item.Quality < 0) item.Quality = 0;
      if (item.Quality > 50) item.Quality = 50;

      return item;
    }

    public Item() {}
    public Item(string name) { Name = name; }

    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
  }
}
