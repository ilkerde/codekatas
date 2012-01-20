namespace KataChrono {
  using System.Globalization;

  public class Chronograph {
    private CultureInfo _culture = CultureInfo.InvariantCulture;

    public bool IsDirty { get; set; }

    public LocalTime SyncWith(TimeServer ts) {
      var localTime = new LocalTime();

      if (IsDirty) {
        TimeEntry te = ts.GetTime();
        te.Apply(_culture);
        localTime = te.ToLocalTime();
      } else {
        TimeEntry te = new TimeEntry(localTime);
        te.Apply(_culture);
        localTime = te.ToLocalTime();
      }

      return localTime;
    }
  }
}
