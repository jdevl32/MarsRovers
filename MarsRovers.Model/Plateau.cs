using MarsRovers.Model.Interface;

namespace MarsRovers.Model
{

	/// <inheritdoc />
	public class Plateau
		:
		IPlateau
	{

#region Property

		/// <inheritdoc />
		public ILocation Origin { get; }

		/// <inheritdoc />
		public ILocation Boundary { get; }

#endregion

#region Instance Initialization

		/// <summary>
		/// Creates a new plateau from origin and boundary values.
		/// </summary>
		/// <param name="origin">
		/// The origin location coordinates.
		/// </param>
		/// <param name="boundary">
		/// The boundary location coordinates.
		/// </param>
		public Plateau(ILocation origin, ILocation boundary)
		{
			Origin = origin;
			Boundary = boundary;
		}

#endregion

		/// <inheritdoc />
		public void Validate()
		{
			// The boundary coordinates cannot be less than the origin coordinates.
			if (Boundary.X < Origin.X || Boundary.Y < Origin.Y)
			{
				// todo: implement new exception type
				throw new System.Exception();
			} // if
		}
	}

}
