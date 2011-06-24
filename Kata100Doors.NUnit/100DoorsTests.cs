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

    [Test]
    public void Given_4_closed_doors_when_second_monkey_runs_through_floor_then_monkey_opens_only_every_second_door() {
      Floor floor = new Floor(4);
      Monkey monkey = new Monkey(2);
      monkey.RunThrough(floor);
      Door[] doors = floor.GetDoors();
      Assert.That(doors.Where((door, index) => (index + 1) % 2 == 0).All(door => door.IsOpen));
      Assert.That(doors.Where((door, index) => (index + 1) % 2 != 0).All(door => door.IsClosed));
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
