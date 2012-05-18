namespace Kata {
  using System;
  using System.Collections.Generic;

  class Program {
    public Store Store { get; set; }

    static void Main(string[] args)
    {
      System.Console.WriteLine("OMGHAI!");

      var app = new Program
      {
        Store = Store.Create(new [] {
          new Item (N_.Vest) { SellIn = 10, Quality = 20},
          new Item (N_.AgedBrie) { SellIn = 2, Quality = 0},
          new Item (N_.Elixir) { SellIn = 5, Quality = 7},
          new Item (N_.Sulfuras) { SellIn = 0, Quality = 80},
          new Item (N_.ConcertTickets) { SellIn = 15, Quality = 20},
          new Item (N_.Cake) { SellIn = 3, Quality = 6}
        }, i => Store.UpdateItem(i))
      };

      app.Store.UpdateQuality();

      System.Console.ReadKey();
    }
  }

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

      if (item.Name == N_.AgedBrie || item.Name == N_.ConcertTickets)
      {
          if (item.Quality < 50)
          {
              item.Quality = item.Quality + 1;

              if (item.Name == N_.ConcertTickets)
              {
                  if (item.SellIn < 11)
                  {
                      if (item.Quality < 50)
                      {
                          item.Quality = item.Quality + 1;
                      }
                  }

                  if (item.SellIn < 6)
                  {
                      if (item.Quality < 50)
                      {
                          item.Quality = item.Quality + 1;
                      }
                  }
              }
          }
      } else
        item.Quality--;

      item.SellIn = item.SellIn - 1;

      if (item.SellIn < 0)
      {
          if (item.Name != N_.AgedBrie)
          {
              if (item.Name == N_.ConcertTickets)
              {
                  item.Quality = item.Quality - item.Quality;
              }
          }
          else
          {
              if (item.Quality < 50)
              {
                  item.Quality = item.Quality + 1;
              }
          }
      }

      if (item.Quality < 0) item.Quality = 0;

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
