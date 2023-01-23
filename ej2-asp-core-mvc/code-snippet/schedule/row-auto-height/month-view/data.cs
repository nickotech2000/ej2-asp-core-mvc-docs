public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    { Id = 1, Subject = "Explosion of Betelgeuse Star", Location = "Dallas", StartTime = new DateTime(2023, 1, 10, 9, 30, 0), EndTime = new DateTime(2023, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 2, Subject = "Thule Air Crash Report", Location = "Texas", StartTime = new DateTime(2023, 1, 10, 12, 0, 0), EndTime = new DateTime(2023, 1, 10, 14, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 3, Subject = "Blue Moon Eclipse", Location = "Australia", StartTime = new DateTime(2023, 1, 10, 10, 30, 0), EndTime = new DateTime(2023, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 4, Subject = "Meteor Showers in 2019", Location = "Canada", StartTime = new DateTime(2023, 1, 10, 13, 0, 0), EndTime = new DateTime(2023, 1, 10, 14, 30, 0) });
    appData.Add(new AppointmentData
    { Id = 5, Subject = "Milky Way as Melting pot", Location = "Mexico", StartTime = new DateTime(2023, 1, 10, 12, 0, 0), EndTime = new DateTime(2023, 1, 10, 14, 0, 0) });
    return appData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Location { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}