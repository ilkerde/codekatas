namespace KataChrono {
  using System.Globalization;

  public sealed class TimeServer {
    public TimeEntry GetTime() { return null; }
  }

  public sealed class TimeEntry {
    public TimeEntry(LocalTime lt) {}
    public void Apply(CultureInfo ci) {}
    public void Ensure(CultureInfo ci) {}
    public LocalTime ToLocalTime() { return null; }
  }

  public sealed class LocalTime {}
}
