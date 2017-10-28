using System;

namespace MarsRovers.Model.Interface
{

	/// <summary>
	/// A position consists of a location and an orientation.
	/// </summary>
	/// <remarks>
	/// Two positions may occupy the same location, as long as their orientations differ.
	/// </remarks>
	public interface IPosition
	{

#region Property

		/// <summary>
		/// The location of this position.
		/// </summary>
		ILocation Location { get; }

		/// <summary>
		/// The orientation of this position.
		/// </summary>
		/// <remarks>
		/// The orientation uniquely identifies this position from all others at the same location.
		/// </remarks>
		char Orientation { get; }

#endregion

#region Object

		/// <summary>
		/// The string representation of this position.
		/// </summary>
		/// <returns>
		/// String representing this position.
		/// </returns>
		string ToString();

#endregion

		/// <summary>
		/// Moves the location of this position.
		/// </summary>
		/// <param name="location">
		/// The new location of this position.
		/// </param>
		/// <returns>
		/// The previous location of this position.
		/// </returns>
		/// <remarks>
		/// Only the location of this position is affected.
		/// </remarks>
		ILocation Relocate(ILocation location);

		/// <summary>
		/// Modifies the orientation of this position.
		/// </summary>
		/// <param name="orientation">
		/// The new orientation of this position.
		/// </param>
		/// <returns>
		/// The previous orientation of this position.
		/// </returns>
		/// <remarks>
		/// Only the orientation of this position is affected.
		/// </remarks>
		char Reorient(char orientation);

		/// <summary>
		/// Modifies the location and orientation of this position.
		/// </summary>
		/// <param name="location">
		/// The new location of this position.
		/// </param>
		/// <param name="orientation">
		/// The new orientation of this position.
		/// </param>
		/// <returns>
		/// The previous position (as a tuple of the previous location and orientation).
		/// </returns>
		/// <remarks>
		/// Both the location and orientation of this position are affected.
		/// </remarks>
		Tuple<ILocation, char> Reposition(ILocation location, char orientation);

	}

}
