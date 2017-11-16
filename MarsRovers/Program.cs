using MarsRovers.Model;
using System;
using System.IO;
using System.Linq;

namespace MarsRovers
{

	internal class Program
	{

#region Constant

		private const string InputFilePath = @".\Data\in.txt";

		private const string OutputFilePath = @".\Data\out.txt";

		private const char Separator = ' ';

#endregion

		private static void Main(string[] args)
		{
			// Read all lines of the input file.
			var lines = File.ReadAllLines(InputFilePath);
			var index = 0;
			// First line contains the plateau boundary.
			var boundary = lines[index++].Split(' ');
			// Create plateau using the input boundary.
			var plateau = new Plateau(new Location(0, 0), new Location(Convert.ToInt32(boundary[0]), Convert.ToInt32(boundary[1])));
			// Create the squad assigned to the plateau.
			var squad = new Squad(plateau);

			// The remaining pairs of lines are used to create the rovers.
			while (index < lines.Length)
			{
				// Rovers will have a 1-based id based on the index.
				var id = index;
				// The first line of the pair contains the rover position (location and orientation).
				var position = lines[index++].Split(Separator);
				// The second line of the pair contains the rover navigation instructions.
				var instructions = lines[index++];

				// Create the rover using the input, and add it to the squad.
				squad.Rovers.Add(new Rover(id, instructions, new Position(new Location(Convert.ToInt32(position[0]), Convert.ToInt32(position[1])), Convert.ToChar(position[2])), squad));
			} // while

			// The squad of rovers have been created -- deploy them for navigation of the plateau.
			squad.Deploy();

			// Write the final positions of the rovers to the output file.
			File.WriteAllLines(OutputFilePath, squad.Rovers.Select(rover => rover.Position.ToString()).ToList());
		}

	}

}
