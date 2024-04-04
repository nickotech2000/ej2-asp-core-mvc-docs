public IActionResult Index()
{
    ViewBag.DataSource = ganttData();
    return View();
}

 public static List<GanttDataSource> ganttData()
        {
            List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();

            GanttDataSource Record1 = new GanttDataSource()
            {
                TaskId = 1,
                TaskName = "Project initiation",
                StartDate = new DateTime(2024, 04, 02),
                EndDate = new DateTime(2024, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Child1 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Identify site location",
                StartDate = new DateTime(2024, 04, 02),
                Duration = 4,
                Progress = 70,
                DurationUnit="day"
            };
            GanttDataSource Child2 = new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2024, 04, 02),
                Duration = 16,
                Progress = 50,
                DurationUnit = "hour"
            };
            GanttDataSource Child3 = new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2024, 04, 02),
                Duration = 480,
                Progress = 50,
                DurationUnit = "minute"
            };
            Record1.SubTasks.Add(Child1);
            Record1.SubTasks.Add(Child2);
            Record1.SubTasks.Add(Child3);

            GanttDataSource Record2 = new GanttDataSource()
            {
                TaskId = 5,
                TaskName = "Project estimation",
                StartDate = new DateTime(2024, 04, 02),
                EndDate = new DateTime(2024, 04, 21),
                SubTasks = new List<GanttDataSource>()
            };
            GanttDataSource Child4 = new GanttDataSource()
            {
                TaskId = 6,
                TaskName = "Develop floor plan for estimation",
                StartDate = new DateTime(2024, 04, 04),
                Duration = 24,
                Progress = 70,
                DurationUnit = "hour"

            };
            GanttDataSource Child5 = new GanttDataSource()
            {
                TaskId = 7,
                TaskName = "List materials",
                StartDate = new DateTime(2024, 04, 04),
                Duration = 3,
                Progress = 50,
                DurationUnit = "day"

            };
            Record2.SubTasks.Add(Child4);
            Record2.SubTasks.Add(Child5);

            GanttDataSourceCollection.Add(Record1);
            GanttDataSourceCollection.Add(Record2);

            return GanttDataSourceCollection;
        }
       
        public class GanttDataSource
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int? Duration { get; set; }
            public int Progress { get; set; }
            public string DurationUnit { get; set; }
            
            public List<GanttDataSource> SubTasks { get; set; }
        }