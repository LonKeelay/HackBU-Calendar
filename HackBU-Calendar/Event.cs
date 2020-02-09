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
        makeRRULE();
		return RRULE;
    }

	public void makeRRULE()
    {
		RRULE = "RRULE:FREQ=WEEKLY;UNTIL=";
        String end = endTime.ToString("yyyyMMdd");
		RRULE = RRULE + end;
    }

    public string recurDays()
    {
        string dayp = "";
        //The indexes are the days in order starting on Monday
        if (days[0])
        {
            dayp += "MO,";
        }
        if (days[1])
        {
            dayp += "TU,";
        }
        if (days[2])
        {
            dayp += "WE,";
        }
        if (days[3])
        {
            dayp += "TH,";
        }
        if (days[4])
        {
            dayp += "FR,";
        }
        if (days[5])
        {
            dayp += "SA,";
        }
        if (days[6])
        {
            dayp += "SU,";
        }
        //Get rid of last comma
        dayp.Trim(',');
        return dayp;
    }
}
