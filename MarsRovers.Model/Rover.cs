using MarsRovers.Model.Exception;
using MarsRovers.Model.Interface;

namespace MarsRovers.Model
{

	public class Rover
		:
		IRover
	{

#region Property

		public int DeploySequenceId { get; }

		public string NavigationInstructions { get; }

		public IPosition Position { get; }

		private ISquad Squad { get; }

#endregion

#region Instance Initialization

		public Rover(int deploySequenceId, string navigationInstructions, IPosition position, ISquad squad)
		{
			DeploySequenceId = deploySequenceId;
			NavigationInstructions = navigationInstructions;
			Position = position;
			Squad = squad;
		}

#endregion

		//public override string ToString()
		//{
		//	return $"{Position}";
		//}

		public void Navigate(IPlateau plateau)
		{
			foreach (var navigationInstruction in NavigationInstructions)
			{
				switch (navigationInstruction)
				{
					case NavigationInstruction.MoveForward:
						var newLocation = Position.Location.GetNewLocation(NASA.GetSizeLocation(Position.Orientation), NASA.DefaultCountLocation, plateau.Origin, plateau.Boundary);

						if (Squad.IsLocationOccupied(newLocation))
						{
							throw new LocationOccupiedException();
						} // if

						Position.Relocate(newLocation);
						break;

					case NavigationInstruction.PivotLeft:
					case NavigationInstruction.PivotRight:
						//try
						//{
						//}
						//catch (InvalidInstructionException)
						//{
						//	// ignore
						//}

						Position.Reorient(NASA.GetNewOrientation(Position.Orientation, navigationInstruction));
						break;
				} // switch
			} // foreach
		}

	}

}
