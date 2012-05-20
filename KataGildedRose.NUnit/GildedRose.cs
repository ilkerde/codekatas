namespace Kata {
  using System;
  using System.Collections.Generic;

  class Program {
    public Store Store { get; set; }

    static void Main(string[] args)
    {
      System.Console.WriteLine("OMGHAI!");

      var app = new Program
      {
        Store = Store.Create(new [] {
          new Item (N_.Vest) { SellIn = 10, Quality = 20},
          new Item (N_.AgedBrie) { SellIn = 2, Quality = 0},
          new Item (N_.Elixir) { SellIn = 5, Quality = 7},
          new Item (N_.Sulfuras) { SellIn = 0, Quality = 80},
          new Item (N_.ConcertTickets) { SellIn = 15, Quality = 20},
          new Item (N_.Cake) { SellIn = 3, Quality = 6}
        }, i => Item.Update(i))
      };

      app.Store.Update();

      System.Console.ReadKey();
    }
  }
}
