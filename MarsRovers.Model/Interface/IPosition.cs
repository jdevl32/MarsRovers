using System;

namespace MarsRovers.Model.Interface
{

	public interface IPosition
	{

#region Property

		ILocation Location { get; }

		char Orientation { get; }

#endregion

#region Object

		string ToString();

#endregion

		ILocation Relocate(ILocation location);

		char Reorient(char orientation);

		Tuple<ILocation, char> Reposition(ILocation location, char orientation);

	}

}
