namespace HundredDoorsKata {
  using System;
  using System.Linq;

  public class Floor {
    public Door[] GetDoors() {
      return Enumerable.Range(1, 100).Select(i => new Door{ IsClosed = true }).ToArray();
    }
  }

  public class Door {
    public bool IsClosed { get; set; }
    public bool IsOpen { get; set; }
  }

  public class Monkey {
    public Monkey(int number) {
    }

    public void RunThrough(Floor floor) {
    }
  }
}
