using MarsRovers.Model.Exception;
using MarsRovers.Model.Interface;
using System;
using System.Collections.Generic;

namespace MarsRovers.Model
{

	public static class NASA
	{

		public const int DefaultCoordinateCount = 1;

		public static ILocation DefaultCountLocation { get; }

		private static IDictionary<char, Tuple<ILocation, char, char>> ExplorationHelper { get; }

#region Type Initialization

		static NASA()
		{
			DefaultCountLocation = new Location(DefaultCoordinateCount, DefaultCoordinateCount);
			//_InitializeExplorationHelper();
			ExplorationHelper = new Dictionary<char, Tuple<ILocation, char, char>>(4)
			{
				{
					CardinalCompassPoint.East
					,
					new Tuple<ILocation, char, char>(new Location(1, 0), CardinalCompassPoint.North, CardinalCompassPoint.South)
				}
				,
				{
					CardinalCompassPoint.North
					,
					new Tuple<ILocation, char, char>(new Location(0, 1), CardinalCompassPoint.West, CardinalCompassPoint.East)
				}
				,
				{
					CardinalCompassPoint.South
					,
					new Tuple<ILocation, char, char>(new Location(0, -1), CardinalCompassPoint.East, CardinalCompassPoint.West)
				}
				,
				{
					CardinalCompassPoint.West
					,
					new Tuple<ILocation, char, char>(new Location(-1, 0), CardinalCompassPoint.South, CardinalCompassPoint.North)
				}
			};
		}

#endregion

		//private IList<Rover> RoverSquad { get; }

		//private static void _InitializeExplorationHelper()
		//{
		//}

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

		public static ILocation GetSizeLocation(char orientation) => ExplorationHelper[orientation].Item1;

	}

}
