using System;

namespace MarsRovers.Model.Interface
{

	/// <inheritdoc />
	/// <summary>
	/// A location consists of X- and Y- coordinate values.
	/// </summary>
	public interface ILocation
		:
		IEquatable<ILocation>
	{

#region Property

		/// <summary>
		/// The X-coordinate value of the location.
		/// </summary>
		/// <value>
		/// Defined as integer, but assumed to be non-negative value only (since Plateau base/origin is defined as (0, 0)).
		/// </value>
		int X { get; }

		/// <summary>
		/// The Y-coordinate value of the location.
		/// </summary>
		/// <value>
		/// Defined as integer, but assumed to be non-negative value only (since Plateau base/origin is defined as (0, 0)).
		/// </value>
		int Y { get; }

#endregion

		/// <summary>
		/// Gets a new location based on this location, move parameters and boundary limits.
		/// </summary>
		/// <param name="size">
		/// The number of units to move (default is 1).  The total move is the product of count and size.
		/// </param>
		/// <param name="count">
		/// </param>
		/// The number of times to move the unit size (default is 1).  The total move is the product of count and size.
		/// <param name="boundaryMin">
		/// The boundary min limit, which the new location may not fall below.
		/// </param>
		/// <param name="boundaryMax">
		/// The boundary max limit, which the new location may not exceed.
		/// </param>
		/// <returns>
		/// A new location.
		/// </returns>
		ILocation GetNewLocation(ILocation size, ILocation count, ILocation boundaryMin, ILocation boundaryMax);

		/// <summary>
		/// Gets a new location based on this location, move parameters and (plateau) boundary.
		/// </summary>
		/// <param name="size">
		/// The number of units to move (default is 1).  The total move is the product of count and size.
		/// </param>
		/// <param name="count">
		/// </param>
		/// The number of times to move the unit size (default is 1).  The total move is the product of count and size.
		/// <param name="boundary">
		/// The boundary limits, which the new location may not exceed.
		/// </param>
		/// <returns>
		/// A new location.
		/// </returns>
		ILocation GetNewLocation(ILocation size, ILocation count, IPlateau boundary);

#region IEquatable<ILocation>

		/// <summary>
		/// Determines equality with another location.
		/// </summary>
		/// <param name="location">
		/// The target location to test for equality with.
		/// </param>
		/// <returns>
		/// Boolean indicating equality with target location.
		/// </returns>
		bool Equals(ILocation location);

#endregion

#region Object

		/// <summary>
		/// Determines equality with another object.
		/// </summary>
		/// <param name="obj">
		/// The target object to test for equality with.
		/// </param>
		/// <returns>
		/// Boolean indicating equality with target object.
		/// </returns>
		bool Equals(object obj);

		/// <summary>
		/// Numeric code which should uniquely indentify a location.
		/// </summary>
		/// <returns>
		/// Integer uniquely indentifying this location.
		/// </returns>
		int GetHashCode();

		/// <summary>
		/// The string representation of a location.
		/// </summary>
		/// <returns>
		/// String representing this location.
		/// </returns>
		string ToString();

#endregion

	}

}
