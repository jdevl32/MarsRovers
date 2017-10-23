using MarsRovers.Model;
using System;
using System.IO;
using System.Linq;

namespace MarsRovers
{

	internal class Program
	{

		private const string InputFilePath = @".\Data\in.txt";

		private const string OutputFilePath = @".\Data\out.txt";

		private const char Separator = ' ';

		private static void Main(string[] args)
		{
			var lines = File.ReadAllLines(InputFilePath);
			var index = 0;
			var boundary = lines[index++].Split(' ');
			var plateau = new Plateau(new Location(0, 0), new Location(Convert.ToInt32(boundary[0]), Convert.ToInt32(boundary[1])));
			var squad = new Squad(plateau);

			while (index < lines.Length)
			{
				// Rovers will have a 1-based id based on the index.
				var id = index;
				var position = lines[index++].Split(Separator);
				var instructions = lines[index++];

				squad.Rovers.Add(new Rover(id, instructions, new Position(new Location(Convert.ToInt32(position[0]), Convert.ToInt32(position[1])), Convert.ToChar(position[2])), squad));
			} // while

			squad.Deploy();
			File.WriteAllLines(OutputFilePath, squad.Rovers.Select(rover => rover.Position.ToString()).ToList());
		}

	}

}
