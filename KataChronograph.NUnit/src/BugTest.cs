namespace KataChrono {
  using System;
  using System.Globalization;
  using NUnit.Framework;

  [TestFixture]
  public class When_chrono_is_in_sync {
    [Test]
    public void Then_culture_is_ensured_with_time_entry() {
      var ensureWasCalled = false;

      var ts = new TimeServer();
      var chrono = new Chronograph();

      chrono.IsDirty = false;
      chrono.SyncWith(ts);

      Assert.IsTrue(ensureWasCalled);
    }
  }

  public static class TimeEntryImplant {
    public delegate void Ensure(CultureInfo culture);
  }
}
