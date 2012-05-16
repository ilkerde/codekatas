namespace Kata {
  using NUnit.Framework;

  [TestFixture]
  public class When_Item_Is_Conjured {
    [Test]
    public void Then_Degrades_Twice_As_Fast() {
      var quality = Store.UpdateQuality(_item).Quality;
      Assert.AreEqual(4, quality);
    }

    Item _item = new Item { 
      Name = "Conjured Mana Cake", 
      SellIn = 3,
      Quality = 6
    };
  }
}
