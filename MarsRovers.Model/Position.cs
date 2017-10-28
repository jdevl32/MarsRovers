using MarsRovers.Model.Interface;
using System;

namespace MarsRovers.Model
{

	/// <inheritdoc />
	public class Position
		:
		IPosition
	{

#region Property

		/// <inheritdoc />
		public ILocation Location { get; private set; }

		/// <inheritdoc />
		public char Orientation { get; private set; }

#endregion

#region Instance Initialization

		/// <summary>
		/// Creates a new position from location and orientation values.
		/// </summary>
		/// <param name="location">
		/// The location coordinates.
		/// </param>
		/// <param name="orientation">
		/// The orientation.
		/// </param>
		public Position(ILocation location, char orientation)
		{
			Location = location;
			Orientation = orientation;
		}

#endregion

#region Object

		public override string ToString() => $"{Location} {Orientation}";

#endregion

		/// <inheritdoc />
		public ILocation Relocate(ILocation location)
		{
			var oldLocation = Location;
			Location = location;
			return oldLocation;
		}

		/// <inheritdoc />
		public char Reorient(char orientation)
		{
			var oldOrientation = Orientation;
			Orientation = orientation;
			return oldOrientation;
		}

		/// <inheritdoc />
		public Tuple<ILocation, char> Reposition(ILocation location, char orientation) => new Tuple<ILocation, char>(Relocate(location), Reorient(orientation));

	}

}
