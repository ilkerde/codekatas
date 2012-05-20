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
      N_.Elixir
        .WithQuality(0)
        .ShouldHaveQuality(0);
    }
  }

  [TestFixture]
  public class When_Item_Is_Sulfuras {
    [Test]
    public void Then_Quality_Doesnt_Change_At_All() {
      N_.Sulfuras
        .WithQuality(4)
        .ShouldHaveQuality(4);
    }

    [Test]
    public void Then_SellIn_Doesnt_Change_At_All() {
      N_.Sulfuras
        .WithSellIn(3)
        .ShouldHaveSellIn(3);
    }
  }

  [TestFixture]
  public class When_Sulfuras_SellIn_Is_Negative {
    [Test]
    public void Then_Quality_Doesnt_Change_At_All() {
      N_.Sulfuras
        .WithQuality(5)
        .AndSellIn(-5)
        .ShouldHaveQuality(5);
    }
  }

  [TestFixture]
  public class When_Item_Is_AgedBrie_And_SellIn_Is_Not_Due {
    [Test]
    public void Then_Quality_Increases() {
      N_.AgedBrie
        .WithQuality(3)
        .AndSellIn(1)
        .ShouldHaveQuality(4);
    }
  }

  [TestFixture]
  public class When_Item_Is_AgedBrie_And_SellIn_Is_Overdue {
    [Test]
    public void Then_Quality_Increases_Doubled() {
      N_.AgedBrie
        .WithQuality(3)
        .AndSellIn(-1)
        .ShouldHaveQuality(5);
    }
  }

  [TestFixture]
  public class When_Item_Is_AgedBrie_And_Quality_Is_Already_50 {
    [Test]
    public void Then_Quality_Remains_At_50() {
      N_.AgedBrie
        .WithQuality(50)
        .ShouldHaveQuality(50);
    }
  }

  [TestFixture]
  public class When_Item_Is_Tickets_And_SellIn_Is_More_Than_10_Days_Ahead {
    [Test]
    public void Then_Quality_Increases_By_One() {
      N_.ConcertTickets
        .WithQuality(1)
        .AndSellIn(11)
        .ShouldHaveQuality(2);
    }
  }

  public static class ItemTestExtensions {
    public static Item WithQuality(this string name, int quality) {
      return new Item(name) { Quality = quality };
    }

    public static Item WithSellIn(this string name, int sellIn) {
      return new Item(name) { SellIn = sellIn };
    }

    public static Item AndSellIn(this Item item, int sellIn) {
      item.SellIn = sellIn;
      return item;
    }

    public static void ShouldHaveQuality(this Item item, int expectedQuality) {
      Assert.AreEqual(expectedQuality, Store.UpdateItem(item).Quality);
    }

    public static void ShouldHaveSellIn(this Item item, int expectedSellIn) {
      Assert.AreEqual(expectedSellIn, Store.UpdateItem(item).SellIn);
    }
  }
}
