namespace KataChrono {
  using System.Globalization;

  public static class TimeEntryImplant {
    public delegate void Ensure(CultureInfo culture);

    public static void EnsureImplant(this TimeEntry entry, CultureInfo culture, Ensure implant) {
      (implant ?? entry.Ensure)(culture);
    }
  }
}
