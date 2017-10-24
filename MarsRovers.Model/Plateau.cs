using MarsRovers.Model.Interface;

namespace MarsRovers.Model
{

	public class Plateau
		:
		IPlateau
	{

#region Property

		public ILocation Origin { get; }

		public ILocation Boundary { get; }

#endregion

#region Instance Initialization

		public Plateau(ILocation origin, ILocation boundary)
		{
			Origin = origin;
			Boundary = boundary;
		}

#endregion

	}

}
