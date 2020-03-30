using System;
namespace LifeofSi.Objects
{
    public class Events
    {
        public Events()
        {
        }

    //    private List<Event> AllEvents { get; set; }

    //    private List<Event> GetEvents()
    //    {
    //        return new List<Event>()
    //        {
    //            new Event{ EventTitle = "Camping", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(0, 0, 12, 00).Ticks)},
    //        };
    //    }

    //    private void Setup()
    //    {
    //        AllEvents = GetEvents();
    //        eventList.ItemsSource = AllEvents;

    //        Device.StartTimer(new TimeSpan(0, 0, 1), () =>
    //        {
    //            foreach (var evt in AllEvents)
    //            {
    //                var timespan = evt.Date - DateTime.Now;
    //                evt.Timespan = timespan;
    //            }

    //            eventList.ItemsSource = null;
    //            eventList.ItemsSource = AllEvents;

    //            return true;
    //        });
    //    }
    //}

    //public class Event
    //{
    //    public DateTime Date { get; set; }
    //    public string EventTitle { get; set; }
    //    public TimeSpan Timespan { get; set; }

    //    public string Minutes => Timespan.Minutes.ToString("00");
    //    public string Seconds => Timespan.Seconds.ToString("00");
    //}
}
}
