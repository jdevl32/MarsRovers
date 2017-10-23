using System.Collections.Generic;

namespace MarsRovers.Model
{
	public class Squad
	{
		public IList<Rover> Rovers { get; }

		public Plateau Plateau { get; }
	}
}
