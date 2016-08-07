using System;
namespace FruitBasket
{
	public class Space
	{
		// Value the space holds
		public string Icon;

		// Value of tile when hidden
		public string Blank;

		// Whether or not the space has already been revealed
		public bool Revealed;

		public Space()
		{
			Icon = "";
			Blank = "";
			Revealed = false;
		}

		public Space(string value, string blank, bool show)
		{
			Icon = value;
			Blank = blank;
			Revealed = show;
		}

	}
}

