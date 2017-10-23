namespace MarsRovers.Model
{
	public class Rover
	{
		public int DeploySequenceId { get; }

		public Position Position { get; }

		public string NavigationInstructions { get; }

		//public override string ToString()
		//{
		//	return $"{Position}";
		//}

		void Navigate(Plateau plateau)
		{
			foreach (var navigationInstruction in NavigationInstructions)
			{
				switch (navigationInstruction)
				{
					case NavigationInstruction.MoveForward:
						// todo: !!! need to verfiy new location not already notified !!!
						Position.Location = Position.Location.GetNewLocation(NASA.GetSizeLocation(Position.Orientation), NASA.DefaultCountLocation, plateau.Origin, plateau.Boundary);
						break;

					case NavigationInstruction.PivotLeft:
					case NavigationInstruction.PivotRight:
						Position.Orientation = NASA.GetNewOrientation(Position.Orientation, navigationInstruction);
						break;
				} // switch
			} // foreach
		}
	}
}
