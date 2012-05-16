namespace Kata {
  using System;
  using NUnit.Framework;

  [TestFixture]
  public class When_Item_Is_Conjured {
    [Test]
    public void Then_Degrades_Twice_As_Fast() {
      var quality = Store.UpdateItemQuality(_item).Quality;
      Assert.AreEqual(4, quality);
    }

    Item _item = new Item { 
      Name = "Conjured Mana Cake", 
      SellIn = 3,
      Quality = 6
    };
  }

  [TestFixture]
  public class When_Complete_Store_Is_Updated {
    [Test]
    public void Then_Should_Call_UpdateQuality_Each_Item_In_Store() {
      int calls = 0;
      Func<Item, Item> updateItemQuality = item => {
        calls++;
        return item;
      };

      var store = Store.Create(new [] {
        new Item { Name = "Item 1" },
        new Item { Name = "Item 2" },
        new Item { Name = "Item 3" }
      }, updateItemQuality);

      store.UpdateQuality();

      Assert.AreEqual(3, calls);
    }
  }
}
