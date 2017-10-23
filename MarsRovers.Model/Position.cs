namespace MarsRovers.Model
{
	public class Position
	{
#region Property

		public Location Location { get; }

		public char Orientation { get; }

#endregion

#region Instance Initialization

		public Position(Location location, char orientation)
		{
			Location = location;
			Orientation = orientation;
		}

#endregion

		public override string ToString() => $"{Location} {Orientation}";
	}
}
