using System.Collections.Generic;

namespace MarsRovers.Model.Interface
{

	/// <summary>
	/// A squad consists of a list of rovers, and is assigned the same plateau to collectively navigate.
	/// </summary>
	public interface ISquad
	{

#region Property

		/// <summary>
		/// The list of rovers making up this squad.
		/// </summary>
		IList<IRover> Rovers { get; }

		/// <summary>
		/// The plateau which this squad of rovers is to collectively navigate.
		/// </summary>
		IPlateau Plateau { get; }

#endregion

		/// <summary>
		/// Deploys the squad of rovers (to collectively navigate the plateau).
		/// </summary>
		void Deploy();

		/// <summary>
		/// Determines if the location is occupied (by one of the squad rovers).
		/// </summary>
		/// <param name="location">
		/// The location to test for occupation.
		/// </param>
		/// <returns>
		/// Boolean indicating whether the location is occupied (by one of the squad rovers).
		/// </returns>
		bool IsLocationOccupied(ILocation location);

	}

}
