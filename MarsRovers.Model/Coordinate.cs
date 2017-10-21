namespace MarsRovers.Model
{
	public class Coordinate
	{
		/// <summary>
		/// The value of the coordinate.
		/// </summary>
		/// <value>
		/// Defined as integer, but assumed to be non-negative value only (since Plateau base is defined as (0, 0).
		/// </value>
		public int Value { get; set; }
	}
}
