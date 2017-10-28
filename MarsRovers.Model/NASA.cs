using MarsRovers.Model.Exception;
using MarsRovers.Model.Interface;
using System;
using System.Collections.Generic;

namespace MarsRovers.Model
{

	/// <summary>
	/// Representation of the NASA command center.
	/// </summary>
	public static class NASA
	{

		/// <summary>
		/// The default number of coordinates to move.
		/// </summary>
		public const int DefaultCoordinateCount = 1;

		/// <summary>
		/// The location representing the default number of X- and Y- coordinates to move.
		/// </summary>
		public static ILocation DefaultCountLocation { get; }

		/// <summary>
		/// Map containing pre-determined exploration values.
		/// </summary>
		/// <remarks>
		/// The map keys are the four unique cardinal compass points.  The map values are a 3-part tuple containing the:
		/// 1) The unit location size for a move forward navigation instruction in the direction of the cardinal compass point.
		/// 2) The cardinal compass point resulting from a pivot-left navigation instruction.
		/// 3) The cardinal compass point resulting from a pivot-right navigation instruction.
		/// </remarks>
		private static IDictionary<char, Tuple<ILocation, char, char>> ExplorationHelper { get; }

#region Type Initialization

		static NASA()
		{
			DefaultCountLocation = new Location(DefaultCoordinateCount, DefaultCoordinateCount);
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

		/// <summary>
		/// Get the new orientation based on the current orientation and navigation instruction.
		/// </summary>
		/// <param name="orientation">
		/// The current orientation.
		/// </param>
		/// <param name="navigationInstruction">
		/// The navigation instruction.
		/// </param>
		/// <returns>
		/// The new navigation instruction.
		/// </returns>
		public static char GetNewOrientation(char orientation, char navigationInstruction)
		{
			switch (navigationInstruction)
			{
				// Move forward.
				case NavigationInstruction.MoveForward:
					// Orientation is un-affected.
					return orientation;

				// Pivot left.
				case NavigationInstruction.PivotLeft:
					// The new orientation is mapped to the second tuple value.
					return ExplorationHelper[orientation].Item2;

				// Pivot right.
				case NavigationInstruction.PivotRight:
					// The new orientation is mapped to the third tuple value.
					return ExplorationHelper[orientation].Item3;
			}

			throw new InvalidInstructionException();
		}

		/// <summary>
		/// Get the unit location size for a move forward navigation instruction based on the orientation.
		/// </summary>
		/// <param name="orientation">
		/// The orientation of the relevant position.
		/// </param>
		/// <returns>
		/// The unit location size.
		/// </returns>
		public static ILocation GetSizeLocation(char orientation) => ExplorationHelper[orientation].Item1;

	}

}
