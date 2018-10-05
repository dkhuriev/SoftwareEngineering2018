using System;
using System.IO;

namespace TournamentCreator
{
    class Program
    {
        public static void Main(string[] args)
        {
			var operation = args[0];
			switch (operation)
			{
				case "start":
					StartTournament(args[1], args[2]);
					break;
				case "pushWinner":
					PushWinner(args[1], args[2]);
					break;
				default:
					Console.WriteLine("Unknown operation");
					return;
			}
		}

		private static void StartTournament(string tournamentName, string csvParticipants)
		{
			var participants = csvParticipants.Split(',');
			if (TournamentRepository.GetTournament(tournamentName) != null)
			{
				Console.WriteLine("This tournament is already created");
				return;
			}

			var roster = TournamentManager.CreateRoster(participants);
			var tournament = new string[][] { roster };
			TournamentRepository.SaveTournament(tournament);
		}

		private static void PushWinner(string tournamentName, string winner)
		{
			if (TournamentRepository.GetTournament(tournamentName) == null)
			{
				Console.WriteLine("This tournament is not created");
				return;
			}

			var tournament = TournamentRepository.GetTournament(tournamentName);
			var newRoster = TournamentManager.PushWinner(tournament, winner);
			TournamentRepository.SaveTournament(tournament);
		}
    }
}
