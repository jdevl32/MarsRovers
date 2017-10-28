using MarsRovers.Model.Exception;
using MarsRovers.Model.Interface;
using System.Collections.Generic;
using System.Linq;

namespace MarsRovers.Model
{

	/// <inheritdoc />
	public class Squad
		:
		ISquad
	{

#region Property

		/// <inheritdoc />
		public IList<IRover> Rovers { get; }

		/// <inheritdoc />
		public IPlateau Plateau { get; }

#endregion

#region Instance Initialization

		/// <summary>
		/// Creates a new squad of rovers assigned to navigate the plateau.
		/// </summary>
		/// <param name="plateau">
		/// The plateau which is to be navigated by the rovers.
		/// </param>
		public Squad(IPlateau plateau)
		{
			Plateau = plateau;
			Rovers = new List<IRover>();
		}

#endregion

		/// <inheritdoc />
		public void Deploy()
		{
			// Deploy each rover in succession, allowing each to navigate the plateau in turn.
			foreach (var rover in Rovers)
			{
				try
				{
					// Each rover will attempt to navigate the plateau successively.
					rover.Navigate(Plateau);
				}
				catch (MoveException ex)
				{
					// Halt current rover progress and roceed to the next rover.
				}
				catch (System.Exception ex)
				{
				}
			} // foreach
		}

		/// <inheritdoc />
		public bool IsLocationOccupied(ILocation location) => Rovers.Any(rover => rover.Position.Location.Equals(location));

	}

}
