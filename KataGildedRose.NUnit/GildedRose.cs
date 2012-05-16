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

            if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Items[i].Quality > 0)
                {
                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Items[i].Quality = Items[i].Quality - 1;
                    }
                }
            }
            else
            {
                if (Items[i].Quality < 50)
                {
                    Items[i].Quality = Items[i].Quality + 1;

                    if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Items[i].SellIn < 11)
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }

                        if (Items[i].SellIn < 6)
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }
                    }
                }
            }

            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            {
                Items[i].SellIn = Items[i].SellIn - 1;
            }

            if (Items[i].SellIn < 0)
            {
                if (Items[i].Name != "Aged Brie")
                {
                    if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Items[i].Quality > 0)
                        {
                            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                            {
                                Items[i].Quality = Items[i].Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        Items[i].Quality = Items[i].Quality - Items[i].Quality;
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
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
