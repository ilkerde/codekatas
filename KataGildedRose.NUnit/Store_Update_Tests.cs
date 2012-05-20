namespace Kata.Store_Update_Tests {
  using System;
  using NUnit.Framework;

  [TestFixture]
  public class When_Complete_Store_Is_Updated {
    [Test]
    public void Then_Should_Call_Update_Each_Item_In_Store() {
      int calls = 0;
      Func<Item, Item> updateItem = item => {
        calls++;
        return item;
      };

      var store = Store.Create(new [] {
        new Item { Name = "Item 1" },
        new Item { Name = "Item 2" },
        new Item { Name = "Item 3" }
      }, updateItem);

      store.Update();

      Assert.AreEqual(3, calls);
    }
  }

  [TestFixture]
  public class When_Store_Is_Updated_Without_A_Custom_ItemUpdate_Call {
    [Test]
    public void Then_Should_Apply_Degredation_Rules_To_Items_In_Store() {
      var store = Store.Create(new [] {
        new Item { Name = "Item", SellIn = 1, Quality = 2 }
      });

      store.Update();

      Assert.AreEqual(1, store.Items[0].Quality);
    }
  }
}
