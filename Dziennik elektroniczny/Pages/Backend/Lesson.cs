namespace Dziennik_elektroniczny.Pages.Backend
{
  public class Lesson
  {
    public string Name { get; private set; }
    public string Teacher { get; private set; }
    public string Classroom { get; private set; }
    public TimeOnly StartTime { get; private set; }
    public TimeOnly EndTime { get; private set; }
    public TimeSpan Duration => this.EndTime - this.StartTime;

    public Lesson(TimeOnly startTime, TimeOnly endTime, string name, string classroom, string teacher)
    {
      StartTime = startTime;
      EndTime = endTime;
      Name = name;
      Classroom = classroom;
      Teacher = teacher;
    }
  }
}
