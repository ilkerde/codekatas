namespace HundredDoorsKata {
  using System;
  using System.Linq;

  public class Floor {
    private Door[] doors = 
      Enumerable.Range(1, 100)
      .Select(i => new Door())
      .ToArray();

    public Door[] GetDoors() {
      return doors; 
    }
  }

  public class Door {
    public Door() {
      IsClosed = true;
    }

    public bool IsClosed { get; set; }
    public bool IsOpen { get; set; }
  }

  public class Monkey {
    public Monkey(int number) {
    }

    public void RunThrough(Floor floor) {
      foreach (Door door in floor.GetDoors()) {
        door.IsOpen = true;
      }
    }
  }
}
