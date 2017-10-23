using System.Collections.Generic;

namespace MarsRovers.Model.Interface
{

	public interface ISquad
	{

#region Property

		IList<IRover> Rovers { get; }

		IPlateau Plateau { get; }

#endregion

		void Deploy();

		bool IsLocationOccupied(ILocation location);

	}

}
