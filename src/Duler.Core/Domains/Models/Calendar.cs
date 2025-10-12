namespace Duler.Core.Domains;

public class CalendarEvent
{
    public DateTime Date { get; set; }
    public string Time { get; set; } = "";
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Category { get; set; } = "work";
}