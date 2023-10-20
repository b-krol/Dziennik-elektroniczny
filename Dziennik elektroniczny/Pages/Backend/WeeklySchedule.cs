namespace Dziennik_elektroniczny.Pages.Backend
{
  public class WeeklySchedule
  {
    public List<DailySchedule> DailySchedules { get; private set; } = new List<DailySchedule>();
    public WeeklySchedule(List<DailySchedule> dailySchedules)
    {
      this.DailySchedules = dailySchedules;
    }
  }
}
