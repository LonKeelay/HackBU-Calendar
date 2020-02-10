using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HackBU_Calendar
{
	class Occasion
	{
		static string[] Scopes = { CalendarService.Scope.CalendarEvents };
		static string ApplicationName = "Google Calendar Auto Scheduler";

		public String name;
		public String location;
		public DateTime startTime;
		public DateTime endTime;
		public bool[] days;
		public String RRULE;
        public DateTime evStart;
        public DateTime evEnd;
        public DateTime semStart;
        public DateTime semEnd;
        public int color;

		public Occasion(String name, String location, DateTime startTime, DateTime endTime, bool[] days)
		{
			this.name = name;
			this.location = location;
			this.startTime = startTime;
			this.endTime = endTime;
			this.days = days;

		}
		public Occasion()
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
        public void setSemStart(DateTime date)
        {
            this.semStart = date;
        }
        public void setSemEnd(DateTime date)
        {
            this.semEnd = date;
        }
        public void setColor(int col)
        {
            color = col;
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
			String dayp = recurDays();
			RRULE = "RRULE:FREQ=WEEKLY;BYDAY=" + dayp + ";INTERVAL=1;UNTIL=";
			String end = semEnd.ToString("yyyyMMdd");
			RRULE = RRULE + end + "T230000Z";
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
            dayp = dayp.Substring(0, dayp.Length - 1);
			return dayp;
		}

		public void insertEvent()
		{
            switch (semStart.DayOfWeek.ToString())
            {
                case "Monday":
                    if (days[0]) { }
                    else if (days[1]) { semStart = semStart.AddDays(1); }
                    else if (days[2]) { semStart = semStart.AddDays(2); }
                    else if (days[3]) { semStart = semStart.AddDays(3); }
                    else if (days[4]) { semStart = semStart.AddDays(4); }
                    else if (days[5]) { semStart = semStart.AddDays(5); }
                    else if (days[6]) { semStart = semStart.AddDays(6); }
                    break;
                case "Tuesday":
                    if (days[1]) { }
                    else if (days[2]) { semStart = semStart.AddDays(1); }
                    else if (days[3]) { semStart = semStart.AddDays(2); }
                    else if (days[4]) { semStart = semStart.AddDays(3); }
                    else if (days[5]) { semStart = semStart.AddDays(4); }
                    else if (days[6]) { semStart = semStart.AddDays(5); }
                    else if (days[0]) { semStart = semStart.AddDays(6); }
                    break;
                case "Wednesday":
                    if (days[2]) { }
                    else if (days[3]) { semStart = semStart.AddDays(1); }
                    else if (days[4]) { semStart = semStart.AddDays(2); }
                    else if (days[5]) { semStart = semStart.AddDays(3); }
                    else if (days[6]) { semStart = semStart.AddDays(4); }
                    else if (days[0]) { semStart = semStart.AddDays(5); }
                    else if (days[1]) { semStart = semStart.AddDays(6); }
                    break;
                case "Thursday":
                    if (days[3]) { }
                    else if (days[4]) { semStart = semStart.AddDays(1); }
                    else if (days[5]) { semStart = semStart.AddDays(2); }
                    else if (days[6]) { semStart = semStart.AddDays(3); }
                    else if (days[0]) { semStart = semStart.AddDays(4); }
                    else if (days[1]) { semStart = semStart.AddDays(5); }
                    else if (days[2]) { semStart = semStart.AddDays(6); }
                    break;
                case "Friday":
                    if (days[4]) { }
                    else if (days[5]) { semStart = semStart.AddDays(1); }
                    else if (days[6]) { semStart = semStart.AddDays(2); }
                    else if (days[0]) { semStart = semStart.AddDays(3); }
                    else if (days[1]) { semStart = semStart.AddDays(4); }
                    else if (days[2]) { semStart = semStart.AddDays(5); }
                    else if (days[3]) { semStart = semStart.AddDays(6); }
                    break;
                case "Saturday":
                    if (days[5]) { }
                    else if (days[6]) { semStart = semStart.AddDays(1); }
                    else if (days[0]) { semStart = semStart.AddDays(2); }
                    else if (days[1]) { semStart = semStart.AddDays(3); }
                    else if (days[2]) { semStart = semStart.AddDays(4); }
                    else if (days[3]) { semStart = semStart.AddDays(5); }
                    else if (days[4]) { semStart = semStart.AddDays(6); }
                    break;
                case "Sunday":
                    if (days[6]) { }
                    else if (days[0]) { semStart = semStart.AddDays(1); }
                    else if (days[1]) { semStart = semStart.AddDays(2); }
                    else if (days[2]) { semStart = semStart.AddDays(3); }
                    else if (days[3]) { semStart = semStart.AddDays(4); }
                    else if (days[4]) { semStart = semStart.AddDays(5); }
                    else if (days[5]) { semStart = semStart.AddDays(6); }
                    break;
            }
            evStart = new DateTime(semStart.Year, semStart.Month, semStart.Day, startTime.Hour, startTime.Minute, startTime.Second);
            evEnd = new DateTime(semStart.Year, semStart.Month, semStart.Day, endTime.Hour, endTime.Minute, endTime.Second);
            

			makeRRULE();
			UserCredential credential;

			using (var stream =
				new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
			{
				// The file token.json stores the user's access and refresh tokens, and is created
				// automatically when the authorization flow completes for the first time.
				string credPath = "token.json";
				credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
					GoogleClientSecrets.Load(stream).Secrets,
					Scopes,
					"user",
					CancellationToken.None,
					new FileDataStore(credPath, true)).Result;
				Console.WriteLine("Credential file saved to: " + credPath);
			}

			// Create Google Calendar API service.
			var service = new CalendarService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = ApplicationName,
			});
            //based on recurring website thing
            Event e = new Event()
            {
                Summary = name,
                Location = location,
                Start = new EventDateTime()
                {
                    DateTime = evStart,
                    TimeZone = "America/New_York",
                    //"2011-06-03T10:00:00.000:-07:00")
                },
                End = new EventDateTime()
                {
                    DateTime = evEnd,
                    TimeZone = "America/New_York",
                },
                Recurrence = new String[] {
                    RRULE
                },
                Reminders = new Event.RemindersData
                {
                    UseDefault = false
                },
                ColorId = color.ToString()
			};

			Console.WriteLine(RRULE);
			String calendarId = "primary";
			EventsResource.InsertRequest request = service.Events.Insert(e, calendarId);
			Event createdEvent = request.Execute(); //error here
			Console.WriteLine("Event created: {0}", createdEvent.HtmlLink);
		}
	}
}
