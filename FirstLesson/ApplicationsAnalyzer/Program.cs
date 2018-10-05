using System;
using System.Collections.Generic;
using System.IO;

namespace ApplicationsAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var operation = args[0];
			var applications = GetApplications(args[1]);
			switch (operation)
			{
				case "count":
					ShowApplicationsCount(applications);
					break;
				case "showDorm":
					ShowDormLivers(applications);
					break;
				case "courseStatistic":
					ShowCourseStatistic(applications);
					break;
				default:
					Console.WriteLine("Unknown operation");
					return;
			}
		}

		private static void ShowApplicationsCount(string[] applications)
		{
			var applicationsCount = ApplicationsAnalyzer.CountApplications(applications);
			Console.WriteLine("Applications count is " + applicationsCount);
		}

		private static void ShowDormLivers(string[] applications)
		{
			var dormLivers = ApplicationsAnalyzer.GetDormLiversNames(applications);
			foreach (var dormLiver in dormLivers)
			{
				Console.WriteLine(dormLiver);
			}
		}

		private static void ShowCourseStatistic(string[] applications)
		{
			var courseStatistic = ApplicationsAnalyzer.GetCoursesStatistics(applications);
			for (int course = 0; course < courseStatistic.Length; course++)
			{
				Console.WriteLine($"{course} курс - {courseStatistic[course]} человек");
			}
		}

		private static string[] GetApplications(string filePath)
		{
			var applications = new List<string>();
			var lines = File.ReadAllLines(filePath);
			for (int i = 1; i < lines.Length; i++)
			{
				applications.Add(lines[i]);
			}

			return applications.ToArray();
		}
    }
}
