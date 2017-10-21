namespace MarsRovers.Model
{
	public interface IMoveable<T>
	{
		/// <summary>
		/// todo:  possibly not needed !!!
		/// </summary>
		T Value { get; set; }

		/// <summary>
		/// Creates a new moveable object based on this object and the parameters.
		/// </summary>
		/// <param name="size">
		/// The number of units to move (default is 1).  The total move is the product of count and size.
		/// </param>
		/// <param name="count">
		/// The number of times to move the unit size (default is 1).  The total move is the product of count and size.
		/// </param>
		/// <param name="boundary">
		/// </param>
		/// <returns>
		/// A new moveable object.  This object remains as it was prior to the operation.
		/// </returns>
		T FromMove(T size, T count, T boundary);

		/// <summary>
		/// Moves this object based on the parameters.
		/// </summary>
		/// <param name="size">
		/// The number of units to move (default is 1).  The total move is the product of count and size.
		/// </param>
		/// <param name="count">
		/// The number of times to move the unit size (default is 1).  The total move is the product of count and size.
		/// </param>
		/// <param name="boundary">
		/// </param>
		/// <returns>
		/// A new moveable object.  This object remains as it was prior to the operation.
		/// </returns>
		void Move(T size, T count, T boundary);
	}
}
