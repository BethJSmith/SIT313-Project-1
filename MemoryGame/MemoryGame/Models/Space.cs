using System;
namespace MemoryGame
{
	public class Space
	{
		// Value the space holds
		public string icon;

		// Value of tile when hidden
		public string hidden;

		// Whether or not the space has already been revealed
		public bool revealed;

		public Space()
		{
			icon = "";
			hidden = "";
			revealed = false;
		}

		public Space(string value, string blank, bool show)
		{
			icon = value;
			hidden = blank;
			revealed = show;
		}

	}
}

