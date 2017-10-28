namespace MarsRovers.Model.Interface
{

	/// <summary>
	/// A plateau consists of an origin location and boundary location.
	/// </summary>
	public interface IPlateau
	{

#region Property

		/// <summary>
		/// The origin location coordinates of the plateau.
		/// </summary>
		/// <remarks>
		/// This should be the lower-left-most coordinates.
		/// </remarks>
		ILocation Origin { get; }

		/// <summary>
		/// The boundary location coordinates of the plateau.
		/// </summary>
		/// <remarks>
		/// This should be the upper-right-most coordinates.
		/// </remarks>
		ILocation Boundary { get; }

#endregion

		/// <summary>
		/// Determines whether the boundary is at least the value of the origin.
		/// </summary>
		void Validate();

	}

}
