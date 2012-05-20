namespace Kata {
  using System;
  using System.Collections.Generic;

  public class Store {
    public static Store Create(IEnumerable<Item> items) {
      return new Store {
        Items = new List<Item>(items),
        _updateItemQuality = item => Store.UpdateItem(item)
      };
    }

    public static Store Create(IEnumerable<Item> items, Func<Item, Item> updateItemQuality) {
      return new Store {
        Items = new List<Item>(items),
        _updateItemQuality = updateItemQuality
      };
    }

    public List<Item> Items { get; private set; }
    private Func<Item, Item> _updateItemQuality;

    public static Item UpdateItem(Item item) {
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

    public void UpdateQuality() {
      for (var i = 0; i < Items.Count; i++) {
        var item = Items[i];
        _updateItemQuality(item);
      }
    }
  }
}
