namespace Kata.Item_Tests {
  using System;
  using NUnit.Framework;

  [TestFixture]
  public class When_Item_Is_Conjured {
    [Test]
    public void Then_Degrades_Twice_As_Fast() {
      var quality = Store.UpdateItem(_item).Quality;
      Assert.AreEqual(4, quality);
    }

    Item _item = new Item(N_.Cake) { 
      SellIn = 3,
      Quality = 6
    };
  }

  [TestFixture]
  public class When_Item_Has_Quality_Of_Zero {
    [Test]
    public void Then_Quality_Doesnt_Degrade_Below_Zero() {
      var quality = Store.UpdateItem(
        new Item { Quality = 1 }
      ).Quality;
      Assert.AreEqual(0, quality);
    }
  }

  [TestFixture]
  public class When_Item_Is_Sulfuras {
    [Test]
    public void Then_Quality_Doesnt_Change_At_All() {
      var quality = Store.UpdateItem(
        new Item(N_.Sulfuras) { Quality = 4 }
      ).Quality;
      Assert.AreEqual(4, quality);
    }

    [Test]
    public void Then_SellIn_Doesnt_Change_At_All() {
      var sellin = Store.UpdateItem(
        new Item(N_.Sulfuras) { SellIn = 3 }
      ).SellIn;
      Assert.AreEqual(3, sellin);
    }
  }

  [TestFixture]
  public class When_Sulfuras_SellIn_Is_Negative {
    [Test]
    public void Then_Quality_Doesnt_Change_At_All() {
      var quality = Store.UpdateItem(
        new Item(N_.Sulfuras) { SellIn = -5, Quality = 5 }
      ).Quality;
      Assert.AreEqual(5, quality);
    }
  }

  [TestFixture]
  public class When_Item_Is_AgedBrie_And_SellIn_Is_Not_Due {
    [Test]
    public void Then_Quality_Increases() {
      var quality = Store.UpdateItem(
        new Item(N_.AgedBrie) { SellIn = 1, Quality = 3 }
      ).Quality;
      Assert.AreEqual(4, quality);
    }
  }

  [TestFixture]
  public class When_Item_Is_AgedBrie_And_SellIn_Is_Overdue {
    [Test]
    public void Then_Quality_Increases_Doubled() {
      var quality = Store.UpdateItem(
        new Item(N_.AgedBrie) { SellIn = -1, Quality = 3 }
      ).Quality;
      Assert.AreEqual(5, quality);
    }
  }
}
