using System.Collections.Generic;

namespace ApplicationsAnalyzer
{
	public static class ApplicationsAnalyzer
    {
		public static int CountApplications(string[] applications)
		{
			return applications.Length;
		} 

		public static string[] GetDormLiversNames(string[] applications)
		{
			var dormLiverNames = new List<string>();
			foreach (var application in applications)
			{
				var applicationElements = GetApplicationElements(application);
				var dormSign = applicationElements[DormSignIndex];
				if (dormSign == "Да")
				{
					dormLiverNames.Add(applicationElements[NameIndex]);
				}
			}

			return dormLiverNames.ToArray();
		}

		public static int[] GetCoursesStatistics(string[] applications)
		{
			var courses = new int[5];
			foreach (var application in applications)
			{
				var applicationElements = GetApplicationElements(application);
				var courseValue = applicationElements[CourseIndex];
				var course = int.Parse(courseValue.Substring(0, 1));
				courses[course]++;
			}

			return courses;
		}

		private static string[] GetApplicationElements(string application)
		{
			return application.Split(';');
		}

		private const int NameIndex = 1;
		private const int DormSignIndex = 4;
		private const int CourseIndex = 2;
    }
}
