using MarsRovers.Model.Exception;
using MarsRovers.Model.Interface;

namespace MarsRovers.Model
{

	/// <inheritdoc />
	public class Rover
		:
		IRover
	{

#region Property

		/// <inheritdoc />
		public int DeploySequenceId { get; }

		/// <inheritdoc />
		public string NavigationInstructions { get; }

		/// <inheritdoc />
		public IPosition Position { get; }

		/// <summary>
		/// The rover squad (to which this rover is a member of).
		/// </summary>
		private ISquad Squad { get; }

#endregion

#region Instance Initialization

		/// <summary>
		/// Creates a new rover.
		/// </summary>
		/// <param name="deploySequenceId">
		/// The unique identifier for the rover among the squad.
		/// </param>
		/// <param name="navigationInstructions">
		/// The set of navigation instructions for the rover.
		/// </param>
		/// <param name="position">
		/// The initial position of the rover (prior to navigating).
		/// </param>
		/// <param name="squad">
		/// The squad of rovers to which this rover belongs.
		/// </param>
		public Rover(int deploySequenceId, string navigationInstructions, IPosition position, ISquad squad)
		{
			DeploySequenceId = deploySequenceId;
			NavigationInstructions = navigationInstructions;
			Position = position;
			Squad = squad;
		}

#endregion

		/// <inheritdoc />
		public void Navigate(IPlateau plateau)
		{
			// Iterate the set of navigation instructions.
			foreach (var navigationInstruction in NavigationInstructions)
			{
				// Process the known navigation instructions.  
				// Invalid or unrecongnized instructions are ignored.
				switch (navigationInstruction)
				{
					// Move forward.
					case NavigationInstruction.MoveForward:
						// Based on the current orientation of the rover and the plateau boundary, 
						// get (from NASA command center) and calculate the new location.
						var newLocation = Position.Location.GetNewLocation(NASA.GetSizeLocation(Position.Orientation), NASA.DefaultCountLocation, plateau.Origin, plateau.Boundary);

						// Make sure the new location is not already occupied by another rover.
						if (Squad.IsLocationOccupied(newLocation))
						{
							// todo: add argument(s)...
							throw new LocationOccupiedException();
						} // if

						// Update the new location of the rover.
						Position.Relocate(newLocation);
						break;

					// Pivot (left or right).
					case NavigationInstruction.PivotLeft:
					case NavigationInstruction.PivotRight:
						// Based on the current orientation of the rover and current navigation instruction, 
						// get the new orientation (from NASA command center).
						Position.Reorient(NASA.GetNewOrientation(Position.Orientation, navigationInstruction));
						break;
				} // switch
			} // foreach
		}

	}

}
