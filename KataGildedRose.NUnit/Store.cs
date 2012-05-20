namespace Kata {
  using System;
  using System.Collections.Generic;

  public class Store {
    public static Store Create(IEnumerable<Item> items) {
      return new Store {
        Items = new List<Item>(items),
        _updateItemQuality = item => Item.Update(item)
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

    public void UpdateQuality() {
      for (var i = 0; i < Items.Count; i++) {
        var item = Items[i];
        _updateItemQuality(item);
      }
    }
  }
}
