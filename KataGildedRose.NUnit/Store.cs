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

      if (item.Name == N_.AgedBrie || item.Name == N_.ConcertTickets) {
        item.Quality = item.Quality + 1;

        if (item.Name == N_.ConcertTickets)
        {
            if (item.SellIn < 11)
            {
              item.Quality = item.Quality + 1;
            }

            if (item.SellIn < 6)
            {
              item.Quality = item.Quality + 1;
            }
        }
      } else
        item.Quality--;

      item.SellIn = item.SellIn - 1;

      if (item.SellIn < 0)
      {
        if (item.Name == N_.ConcertTickets)
          item.Quality = 0;

        if (item.Name == N_.AgedBrie)
          item.Quality = item.Quality + 1;
      }

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
