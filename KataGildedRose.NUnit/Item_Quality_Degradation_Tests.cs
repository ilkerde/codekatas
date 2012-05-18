namespace Kata.Item_Quality_Degradation_Tests {
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
  public class When_Item_Has_Quality_Of_Zero {
    [Test]
    public void Then_Quality_Doesnt_Degrade_Below_Zero() {
      var quality = Store.UpdateItemQuality(
        new Item { Quality = 1 }
      ).Quality;
      Assert.AreEqual(0, quality);
    }
  }
}
