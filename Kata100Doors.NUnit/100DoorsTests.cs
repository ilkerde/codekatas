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

  [TestFixture]
  public class DoorTests {
    [Test]
    public void When_Door_Is_Closed_Then_Door_Is_Not_Open() {
      Assert.That(!new Door{IsClosed = true}.IsOpen);
    }

    [Test]
    public void When_Door_Is_Not_Closed_Then_Door_Is_Open() {
      Assert.That(new Door{IsClosed = false}.IsOpen);
    }
  }
}
