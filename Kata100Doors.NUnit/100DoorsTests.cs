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

    [Test]
    public void Given_doors_are_closed_when_first_monkey_runs_through_floor_then_all_doors_are_open() {
      Floor floor = new Floor();
      Monkey monkey = new Monkey(1);
      monkey.RunThrough(floor);
      Door[] doors = floor.GetDoors();
      Assert.That(doors.All(door => door.IsOpen));
    }
  }
}
