using System;

public class Event
{
	public String name;
	public String location;
	public DateTime startTime;
	public DateTime endTime;
	public Boolean[] days;

	public Event(String name, String location, DateTime startTime, DateTime endTime, Boolean[] days)
	{
		this.name = name;
		this.location = location;
		this.startTime = startTime;
		this.endTime = endTime;
		this.days = days;
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
	//getters
	public String getName()
	{
		return name;
	}
	public String getLocation()
	{
		return location;
	}
	public DateTime setStartTime()
	{
		return startTime;
	}
	public DateTime setEndTime()
	{
		return endTime;
	}
	public Boolean[] setDay()
	{
		return days;
	}
}
