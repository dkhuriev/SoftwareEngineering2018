namespace TournamentCreator
{
	public static class TournamentManager
    {
		public static string[] CreateRoster(string[] participants)
		{
			var shuffledParticipants = Shuffle(participants);
			var pairs = MakePairs(shuffledParticipants);
			return pairs;
		}

		public static string[][] PushWinner(string[][] roster, string winner)
		{
			return roster;
		}

		private static string[] Shuffle(string[] participants)
		{
			// todo: implement
			return participants;
		}

		private static string[] MakePairs(string[] participants)
		{
			// todo: implement
			return participants;
		}



		private const string PairsDivider = "---";
    }
}
