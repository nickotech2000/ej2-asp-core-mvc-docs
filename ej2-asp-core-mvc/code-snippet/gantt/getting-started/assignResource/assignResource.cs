public IActionResult Index()
{
     ViewBag.DataSource = ganttData();
     ViewBag.projectResources = projectResources();
     return View();
}

  public static List<GanttResources> projectResources()
        {
            List<GanttResources> GanttResourcesCollection = new List<GanttResources>();

            GanttResources Record1 = new GanttResources()
            {
                ResourceId = 1,
                ResourceName = "Martin Tamer"
            };
            GanttResources Record2 = new GanttResources()
            {
                ResourceId = 2,
                ResourceName = "Rose Fuller"
            };
            GanttResources Record3 = new GanttResources()
            {
                ResourceId = 3,
                ResourceName = "Margaret Buchanan"
            };
            GanttResources Record4 = new GanttResources()
            {
                ResourceId = 4,
                ResourceName = "Fuller King"
            };
            GanttResources Record5 = new GanttResources()
            {
                ResourceId = 5,
                ResourceName = "Davolio Fuller"
            };
            GanttResources Record6 = new GanttResources()
            {
                ResourceId = 6,
                ResourceName = "Van Jack"
            };
            GanttResources Record7 = new GanttResources()
            {
                ResourceId = 7,
                ResourceName = "Fuller Buchanan"
            };
            GanttResources Record8 = new GanttResources()
            {
                ResourceId = 8,
                ResourceName = "Jack Davolio"
            };
            GanttResources Record9 = new GanttResources()
            {
                ResourceId = 9,
                ResourceName = "Tamer Vinet"
            };
            GanttResources Record10 = new GanttResources()
            {
                ResourceId = 10,
                ResourceName = "Vinet Fuller"
            };
            GanttResources Record11 = new GanttResources()
            {
                ResourceId = 11,
                ResourceName = "Bergs Anton"
            };
            GanttResources Record12 = new GanttResources()
            {
                ResourceId = 12,
                ResourceName = "Construction Supervisor"
            };
            GanttResourcesCollection.Add(Record1);
            GanttResourcesCollection.Add(Record2);
            GanttResourcesCollection.Add(Record3);
            GanttResourcesCollection.Add(Record4);
            GanttResourcesCollection.Add(Record5);
            GanttResourcesCollection.Add(Record6);
            GanttResourcesCollection.Add(Record7);
            GanttResourcesCollection.Add(Record8);
            GanttResourcesCollection.Add(Record9);
            GanttResourcesCollection.Add(Record10);
            GanttResourcesCollection.Add(Record11);
            GanttResourcesCollection.Add(Record12);
            return GanttResourcesCollection;
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
                Duration = 0,
                Progress = 30,
                ResourceId = new int[] { 1 },
                Notes = "Measure the total property area alloted for construction"
            };
            GanttDataSource Child2 = new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2024, 04, 02),
                Duration = 4,
                Predecessor = "2",
                ResourceId = new int[] { 2, 3, 5 },
                Notes = "Obtain an engineered soil test of lot where construction is planned.From an engineer or company specializing in soil testing"
            };
            GanttDataSource Child3 = new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2024, 04, 02),
                Duration = 0,
                Progress = 30,
                Predecessor = "3"
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
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Child4= new GanttDataSource()
            {
                TaskId = 6,
                TaskName = "Develop floor plan for estimation",
                StartDate = new DateTime(2024, 04, 04),
                Duration = 3,
                Progress = 30,
                Predecessor = "4",
                ResourceId = new int[] { 4 },
                Notes = "Develop floor plans and obtain a materials list for estimations"
            };
            GanttDataSource Child5 = new GanttDataSource()
            {
                TaskId = 7,
                TaskName = "List materials",
                StartDate = new DateTime(2024, 04, 04),
                Duration = 3,
                Predecessor = "6",
                ResourceId = new int[] { 4, 8 },
                Notes = ""
            };
            Record2.SubTasks.Add(Child4);
            Record2.SubTasks.Add(Child5);

            GanttDataSourceCollection.Add(Record1);
            GanttDataSourceCollection.Add(Record2);
          
            return GanttDataSourceCollection;
        }
        public class GanttResources
        {
            public int ResourceId { get; set; }
            public string ResourceName { get; set; }
        }
        public class GanttDataSource
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public DateTime BaselineStartDate { get; set; }
            public DateTime BaselineEndDate { get; set; }
            public int? Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public List<GanttDataSource> SubTasks { get; set; }
            public int[] ResourceId { get; set; }
            public string Notes { get; set; }
        }