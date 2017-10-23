using MarsRovers.Model.Exception;
using MarsRovers.Model.Interface;

namespace MarsRovers.Model
{

	public class Location
		:
		ILocation
	{

#region Property

		/// <inheritdoc />
		public int X { get; }

		/// <inheritdoc />
		public int Y { get; }

#endregion

#region Instance Initialization

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public Location(int x, int y)
		{
			X = x;
			Y = y;
		}

#endregion

		/// <summary>
		/// Gets a new coordinate value based on the origin, move parameters and boundary limits.
		/// </summary>
		/// <param name="origin">
		/// The original location from which the move begins.
		/// </param>
		/// <param name="size">
		/// The number of units to move (default is 1).  The total move is the product of count and size.
		/// </param>
		/// <param name="count">
		/// </param>
		/// The number of times to move the unit size (default is 1).  The total move is the product of count and size.
		/// <param name="boundaryMin">
		/// The boundary min limit, which the new coordinate may not fall below.
		/// </param>
		/// <param name="boundaryMax">
		/// The boundary max limit, which the new coordinate may not exceed.
		/// </param>
		/// <returns>
		/// A new coordinate value.
		/// </returns>
		public static int GetNewCoordinate(int origin, int size, int count, int boundaryMin, int boundaryMax)
		{
			origin += size * count;

			if (origin > boundaryMax || origin < boundaryMin)
			{
				throw new BoundaryBreachedException();
			} // if

			return origin;
		}

		/// <inheritdoc />
		public ILocation GetNewLocation(ILocation size, ILocation count, ILocation boundaryMin, ILocation boundaryMax) => new Location(GetNewCoordinate(X, size.X, count.X, boundaryMin.X, boundaryMax.X), GetNewCoordinate(Y, size.Y, count.Y, boundaryMin.Y, boundaryMax.Y));

		//public void Move(ILocation size, ILocation count, ILocation boundary)
		//{
		//	X = GetNewCoordinate(X, size.X, count.X, boundary.X);
		//	Y = GetNewCoordinate(Y, size.Y, count.Y, boundary.Y);
		//}

#region IEquatable<ILocation>

		public bool Equals(ILocation location)
		{
			if (ReferenceEquals(null, location))
			{
				return false;
			}

			if (ReferenceEquals(this, location))
			{
				return true;
			}

			return X == location.X && Y == location.Y;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
			{
				return false;
			}

			if (ReferenceEquals(this, obj))
			{
				return true;
			}

			return obj.GetType() == GetType() && Equals((ILocation) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (X * 397) ^ Y;
			}
		}

		public static bool operator ==(Location left, Location right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Location left, Location right)
		{
			return !Equals(left, right);
		}

#endregion

		public override string ToString() => $"{X} {Y}";

	}

}
