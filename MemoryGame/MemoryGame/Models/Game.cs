using System;
using System.Collections.Generic;

namespace MemoryGame
{
	public class Game
	{
		Random rand = new Random();
		public Space[] grid;
		const string BLANK = "blank.png";

		// Create a list to represent all available icons
		List<string> icons = new List<string>()
		{
			"01.png", "01.png",
			"02.png", "02.png",
			"03.png", "03.png",
			"04.png", "04.png",
			"05.png", "05.png",
			"06.png", "06.png"
		};

		public Game()
		{
			grid = new Space[12];
			AllocateIcons();
		}

		/// <summary>
		/// Randomly allocates all icons to the grid.
		/// </summary>
		private void AllocateIcons()
		{
			int y = icons.Count;
			for (int i = 0; i < y; i++)
			{
				int x = rand.Next(icons.Count);
				grid[i] = new Space(icons[x], BLANK, false); // Check -1
				icons.Remove(icons[x]);
			}
		}

	}
}

