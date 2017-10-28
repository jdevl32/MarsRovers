namespace MarsRovers.Model.Interface
{

	/// <summary>
	/// A rover has a position and set of navigation instructions.
	/// </summary>
	public interface IRover
	{

#region Property

		/// <summary>
		/// A unique identifier indicating the deploy sequence of the rover.
		/// </summary>
		int DeploySequenceId { get; }

		/// <summary>
		/// The set of navigation instructions for the rover.
		/// </summary>
		string NavigationInstructions { get; }

		/// <summary>
		/// The position of the rover.
		/// </summary>
		IPosition Position { get; }

#endregion

		/// <summary>
		/// Instructs the rover to navigate the plateau (using the set of navigation instructions).
		/// </summary>
		/// <param name="plateau"></param>
		void Navigate(IPlateau plateau);

	}

}
