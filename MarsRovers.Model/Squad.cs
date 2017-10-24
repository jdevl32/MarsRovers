using MarsRovers.Model.Exception;
using MarsRovers.Model.Interface;
using System.Collections.Generic;
using System.Linq;

namespace MarsRovers.Model
{

	public class Squad
		:
		ISquad
	{

#region Property

		public IList<IRover> Rovers { get; }

		public IPlateau Plateau { get; }

#endregion

#region Instance Initialization

		public Squad(IPlateau plateau)
		{
			Plateau = plateau;
			Rovers = new List<IRover>();
		}

#endregion

		public void Deploy()
		{
			foreach (var rover in Rovers)
			{
				try
				{
					rover.Navigate(Plateau);
				}
				catch (MoveException ex)
				{
					// Move on to the next rover.
				}
				catch (System.Exception ex)
				{
				}
			} // foreach
		}

		public bool IsLocationOccupied(ILocation location) => Rovers.Any(rover => rover.Position.Location.Equals(location));

	}

}
