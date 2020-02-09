using System;

public class Event
{
	public String name;
	public String location;
	public DateTime startTime;
	public DateTime endTime;
	public bool[] days;
	public String RRULE;

	public Event(String name, String location, DateTime startTime, DateTime endTime, bool[] days)
	{
		this.name = name;
		this.location = location;
		this.startTime = startTime;
		this.endTime = endTime;
		this.days = days;

	}
    public Event()
    {

    }
	//setters
	public void setName(String name)
	{
		this.name = name;
	}
	public void setLocation(String location)
	{
		this.location = location;
	}
	public void setStartTime(DateTime startTime)
	{
		this.startTime = startTime;
	}
	public void setEndTime(DateTime endTime)
	{
		this.endTime = endTime;
	}
	public void setDay(Boolean[] days)
	{
		this.days = days;
	}
	public void setRRULE(String RRULE)
    {
		this.RRULE = RRULE;
    }
	//getters
	public String getName()
	{
		return name;
	}
	public String getLocation()
	{
		return location;
	}
	public DateTime getStartTime()
	{
		return startTime;
	}
	public DateTime getEndTime()
	{
		return endTime;
	}
	public Boolean[] getDay()
	{
		return days;
	}
	public String getRRule()
    {
		return RRULE;
    }

	public void makeRRULE()
    {
		RRULE = "RRULE:FREQ=WEEKLY;UNTIL=";
        String end = endTime.ToString("yyyyMMdd");
		RRULE = RRULE + end;
    }
}
