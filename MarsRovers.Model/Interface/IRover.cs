namespace MarsRovers.Model.Interface
{

	public interface IRover
	{

#region Property

		int DeploySequenceId { get; }

		string NavigationInstructions { get; }

		IPosition Position { get; }

#endregion

		void Navigate(IPlateau plateau);

	}

}
