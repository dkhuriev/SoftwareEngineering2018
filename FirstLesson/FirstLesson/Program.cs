using System;
using System.Collections.Generic;
using System.IO;

namespace FirstLesson
{
    public class Program
    {
		public static void Main(string[] args)
		{
			var operation = args[0];
			switch (operation)
			{
				case "enter":
					Enter(args[1]);
					break;
				case "leave":
					Leave(args[1]);
					break;
				case "show":
					ShowVisitors();
					break;
				default:
					Console.WriteLine("Unknown operation");
					return;
			}
		}

		private static void Enter(string entreeName)
		{
			var visitors = GetVisitors();
			bool alreadyEntered = false;
			foreach (var visitor in visitors)
			{
				if (visitor == entreeName)
				{
					alreadyEntered = true;
				}
			}
			if (alreadyEntered)
			{
				Console.WriteLine("{0} already added to visitors", entreeName);
				return;
			}

			var newVisitors = new List<string>(visitors);
			newVisitors.Add(entreeName);
			SaveVisitors(newVisitors.ToArray());
			Console.WriteLine("{0} added to visitors", entreeName);
		}

		private static void Leave(string lefteeName)
		{
			var visitors = GetVisitors();
			var newVisitors = new List<string>(visitors);
			var alreadyRemoved = !newVisitors.Remove(lefteeName);
			SaveVisitors(newVisitors.ToArray());
			Console.WriteLine(
				"{0} {1}removed from visitors",
				lefteeName,
				alreadyRemoved ? "already " : string.Empty);
		}

		private static void ShowVisitors()
		{
			var visitors = GetVisitors();
			foreach (var visitor in visitors)
			{
				Console.WriteLine(visitor);
			}
		}

		private static string[] GetVisitors()
		{
			if (File.Exists(VisitorsFileName))
			{
				return File.ReadAllLines(VisitorsFileName);
			}

			return new string[0];
		}

		private static void SaveVisitors(string[] newVisitors)
		{
			File.WriteAllLines(VisitorsFileName, newVisitors);
		}

		private const string VisitorsFileName = "visitors.txt";
	}
}
