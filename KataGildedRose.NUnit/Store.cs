namespace Kata {
  using System;
  using System.Collections.Generic;

  public class Store {
    public static Store Create(IEnumerable<Item> items) {
      return new Store {
        Items = new List<Item>(items),
        _updateItem = item => Item.Update(item)
      };
    }

    public static Store Create(IEnumerable<Item> items, Func<Item, Item> updateItem) {
      return new Store {
        Items = new List<Item>(items),
        _updateItem = updateItem
      };
    }

    public List<Item> Items { get; private set; }
    private Func<Item, Item> _updateItem;

    public void Update() {
      for (var i = 0; i < Items.Count; i++) {
        var item = Items[i];
        _updateItem(item);
      }
    }
  }
}
