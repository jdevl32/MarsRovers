using MarsRovers.Model.Interface;
using System;

namespace MarsRovers.Model
{

	public class Position
		:
		IPosition
	{

#region Property

		public ILocation Location { get; private set; }

		public char Orientation { get; private set; }

#endregion

#region Instance Initialization

		public Position(ILocation location, char orientation)
		{
			Location = location;
			Orientation = orientation;
		}

#endregion

#region Object

		public override string ToString() => $"{Location} {Orientation}";

#endregion

		public ILocation Relocate(ILocation location)
		{
			var oldLocation = Location;
			Location = location;
			return oldLocation;
		}

		public char Reorient(char orientation)
		{
			var oldOrientation = Orientation;
			Orientation = orientation;
			return oldOrientation;
		}

		public Tuple<ILocation, char> Reposition(ILocation location, char orientation) => new Tuple<ILocation, char>(Relocate(location), Reorient(orientation));

	}

}
