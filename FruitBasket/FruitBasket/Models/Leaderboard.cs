using System;
using System.Collections.Generic;
using System.IO;
namespace FruitBasket
{
	public class Leaderboard
	{
		private List<HighScore> _Scores;
		private string _Filename;

		public IReadOnlyCollection<HighScore> Scores
		{
			get
			{
				return _Scores.AsReadOnly();
			}
		}

		public Leaderboard(string filename)
		{
			_Scores = new List<HighScore>();
			_Filename = filename;
			LoadScores(_Filename);
		}

		private void LoadScores(string filename)
		{
			StreamReader sr = new StreamReader(File.OpenRead(filename));
			while (!sr.EndOfStream)
			{
				string line = sr.ReadLine();
				string[] values = line.Split(',');

				double x = 0;
				bool result = double.TryParse(values[1], out x);

				if (x > 0)
					_Scores.Add(new HighScore(values[0], x));
			}
			sr.Dispose();
		}

		public void AddScore(string name, double time)
		{
			bool placed = false;

			for (int i = 0; i < _Scores.Count; i++)
			{
				if (!placed && time < _Scores[i].Time)
				{
					_Scores.Insert(i, new HighScore(name, time));
					placed = true;
				}
				i++;
			}

			if (!placed)
				_Scores.Add(new HighScore(name, time));

			WriteFile();
		}

		private void WriteFile()
		{
			var sw = new StreamWriter(_Filename, false);

			sw.WriteLine("Name,Time");
			foreach (HighScore s in _Scores)
				sw.WriteLine(string.Format("{0},{1}", s.Name, s.Time));

			sw.Dispose();
		}
	}
}

