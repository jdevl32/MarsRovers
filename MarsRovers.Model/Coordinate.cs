using MarsRovers.Model.Exception;

namespace MarsRovers.Model
{
	public class Coordinate
		:
		IMoveable<int>
	{
		/// <summary>
		/// The value of the coordinate.
		/// </summary>
		/// <value>
		/// Defined as integer, but assumed to be non-negative value only (since Plateau base/origin is defined as (0, 0).
		/// </value>
		public int Value { get; set; }

		public int FromMove(int size, int count, int boundary)
		{
			var newValue = Value + size * count;

			if (newValue > boundary)
			{
				throw new BoundaryBreachedException();
			} // if

			return newValue;
		}

		public void Move(int size, int count, int boundary) => Value = FromMove(size, count, boundary);
	}
}
