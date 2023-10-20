using Dziennik_elektroniczny.Pages.Backend;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dziennik_elektroniczny.Pages
{
    public class MainModel : PageModel
    {

    public WeeklySchedule WeeklySchedule { get; private set; } =
      new WeeklySchedule(
        new List<DailySchedule>() {
        (new DailySchedule(
          new List<Lesson>() {
            new Lesson(new TimeOnly(7, 10), new TimeOnly(7, 55), "Godzina wychowawcza", "103", "Barbara M."),
            new Lesson(new TimeOnly(8, 0), new TimeOnly(8, 45), "Matematyka", "209", "Janina K."),
            new Lesson(new TimeOnly(8, 55), new TimeOnly(9, 40), "Matematyka", "209", "Janina K.")
          })),
        (new DailySchedule(
          new List<Lesson>() {
            new Lesson(new TimeOnly(7, 10), new TimeOnly(7, 55), "Godzina wychowawcza", "103", "Barbara M."),
            new Lesson(new TimeOnly(8, 0), new TimeOnly(8, 45), "Matematyka", "209", "Janina K."),
            new Lesson(new TimeOnly(8, 55), new TimeOnly(9, 40), "Matematyka", "209", "Janina K.")
          }))
        });


        public void OnGet()
        {
        }
    }
}
