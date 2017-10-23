using MarsRovers.Model.Exception;
using System;
using System.Collections.Generic;

namespace MarsRovers.Model
{
	public static class NASA
	{
		public const int DefaultCoordinateCount = 1;

		public static Location DefaultCountLocation { get; }

		private static IDictionary<char, Tuple<Location, char, char>> ExplorationHelper { get; }

#region Type Initialization

		static NASA()
		{
			DefaultCountLocation = new Location(DefaultCoordinateCount, DefaultCoordinateCount);
			//_InitializeExplorationHelper();
			ExplorationHelper = new Dictionary<char, Tuple<Location, char, char>>(4)
			{
				{
					CardinalCompassPoint.E
					,
					new Tuple<Location, char, char>(new Location(1, 0), CardinalCompassPoint.N, CardinalCompassPoint.S)
				}
				,
				{
					CardinalCompassPoint.N
					,
					new Tuple<Location, char, char>(new Location(0, 1), CardinalCompassPoint.W, CardinalCompassPoint.E)
				}
				,
				{
					CardinalCompassPoint.S
					,
					new Tuple<Location, char, char>(new Location(0, -1), CardinalCompassPoint.E, CardinalCompassPoint.W)
				}
				,
				{
					CardinalCompassPoint.W
					,
					new Tuple<Location, char, char>(new Location(-1, 0), CardinalCompassPoint.S, CardinalCompassPoint.N)
				}
			};
		}

#endregion

		//private IList<Rover> RoverSquad { get; }

		//private static void _InitializeExplorationHelper()
		//{
		//}

		public static Location GetSizeLocation(char orientation) => ExplorationHelper[orientation].Item1;

		public static char GetNewOrientation(char orientation, char instruction)
		{
			switch (instruction)
			{
				case NavigationInstruction.MoveForward:
					return orientation;

				case NavigationInstruction.PivotLeft:
					return ExplorationHelper[orientation].Item2;

				case NavigationInstruction.PivotRight:
					return ExplorationHelper[orientation].Item3;
			}

			throw new InvalidInstructionException();
		}
	}
}
