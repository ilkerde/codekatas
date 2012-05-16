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
          new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
          new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
          new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
          new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
          new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
          new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
        }, i => Store.UpdateItemQuality(i))
      };

      app.Store.UpdateQuality();

      System.Console.ReadKey();
    }
  }

  public class Store {
    public static Store Create(IEnumerable<Item> items) {
      return new Store {
        Items = new List<Item>(items),
        _updateItemQuality = item => Store.UpdateItemQuality(item)
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

    public static Item UpdateItemQuality(Item item) {
      return item;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
          var item = Items[i];
          _updateItemQuality(item);

            if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.Quality > 0)
                {
                    if (item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
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
            }

            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != "Sulfuras, Hand of Ragnaros")
                            {
                                item.Quality = item.Quality - 1;
                            }
                        }
                    }
                    else
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
        }
    }

  }

  public class Item
  {
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
  }
}
