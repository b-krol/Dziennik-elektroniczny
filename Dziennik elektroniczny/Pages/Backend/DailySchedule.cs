namespace Dziennik_elektroniczny.Pages.Backend
{
  public class DailySchedule
  {

    public List<Lesson> Lessons { get; private set; } = new List<Lesson>();

    public DailySchedule(List<Lesson> lessons)
    {
      TimeOnly lastLessonEndTime = new TimeOnly(0);
      foreach (Lesson lesson in lessons)
      {
        if(lastLessonEndTime > lesson.StartTime)
        {
          throw new Exception("overlappingLessonsNotAllowed");
        }
        this.Lessons.Add(lesson);
      }
    }



  }
}
