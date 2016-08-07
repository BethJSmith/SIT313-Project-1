using System;
using System.Collections.Generic;

namespace FruitBasket
{
	public class Game
	{
		Random rand = new Random();
		public Space[] Grid;
		const string BLANK = "Images/blank.png";

		// Create a list to represent all available icons
		List<string> icons = new List<string>()
		{
			"Images/apple.png", "Images/apple.png",
			"Images/banana.png", "Images/banana.png",
			"Images/cherries.png", "Images/cherries.png",
			"Images/grape.png", "Images/grape.png",
			"Images/orange.png", "Images/orange.png",
			"Images/pear.png", "Images/pear.png"
		};

		public Game()
		{
			Grid = new Space[12];
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
				Grid[i] = new Space(icons[x], BLANK, false); // Check -1
				icons.Remove(icons[x]);
			}
		}

	}
}

