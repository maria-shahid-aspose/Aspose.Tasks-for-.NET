
namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars.CreatingUpdatingAndRemoving
{
    public class ReplaceCalendar
    {
        public static void Run()
        {
            // ExStart:ReplaceCalendar
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project = new Project(dataDir + "ReplaceCalendar.mpp");

            // Add a new calendar to the project's calendars collection
            project.Calendars.Add("New cal1", project.Get(Prj.Calendar));

            // Now traverse through project calendars and replace the already added calendar with a new one
            CalendarCollection calColl = project.Calendars;

            foreach (Calendar c in calColl)
            {
                if (c.Name == "New cal1")
                {
                    calColl.Remove(c);
                    calColl.Add("New cal2", project.Get(Prj.Calendar));
                    break;
                }
            }
            // ExEnd:ReplaceCalendar            
        }
    }
}