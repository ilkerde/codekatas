namespace HundredDoorsKata {
  using System;
  using System.Linq;
  using NUnit.Framework;

  [TestFixture]
  public class HundredDoorsAndHundredMonkeysTests {
    [Test]
    public void Given_no_monkeys_all_doors_are_closed() {
      Floor floor = new Floor();
      Door[] doors = floor.GetDoors();
      Assert.That(doors.All(door => door.IsClosed));
    }
  }
}
