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
		/// A new moveable object.
		/// </returns>
		/// <remarks>
		/// This object remains as it was prior to the operation.
		/// </remarks>
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
		/// <remarks>
		/// This object is modified after the operation.
		/// </remarks>
		void Move(T size, T count, T boundary);
	}
}
