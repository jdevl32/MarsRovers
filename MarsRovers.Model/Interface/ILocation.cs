using System;

namespace MarsRovers.Model.Interface
{
	public interface ILocation
		:
		IEquatable<ILocation>
	{

#region Property

		/// <summary>
		/// The X coordinate value of the location.
		/// </summary>
		/// <value>
		/// Defined as integer, but assumed to be non-negative value only (since Plateau base/origin is defined as (0, 0)).
		/// </value>
		int X { get; }

		/// <summary>
		/// The Y coordinate value of the location.
		/// </summary>
		/// <value>
		/// Defined as integer, but assumed to be non-negative value only (since Plateau base/origin is defined as (0, 0)).
		/// </value>
		int Y { get; }

#endregion

		ILocation GetNewLocation(ILocation size, ILocation count, ILocation boundaryMin, ILocation boundaryMax);

#region IEquatable<ILocation>

		//bool Equals(ILocation location);

		bool Equals(object obj);

		int GetHashCode();

#endregion

#region Object

		string ToString();

#endregion

	}

}
