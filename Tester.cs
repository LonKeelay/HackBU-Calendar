using System;

public class Tester
{
	public Tester()
	{

	}

	public static void Main(String[] args)
    {
		String name = "Math";
		String location = "Here";
		DateTime start = new DateTime(08,15,2001, 10,40);
		DateTime end = new DateTime(08, 15, 2001, 11, 30);
		Boolean[] days = { true, false, true, false, true, false, true };
		Event g = new Event(name, location, start, end, days);
		System.Console.WriteLine(g.getName());
    }
}
