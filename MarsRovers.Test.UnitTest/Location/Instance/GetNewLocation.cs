using MarsRovers.Model.Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRovers.Test.UnitTest.Location.Instance
{
	[TestClass]
	public class GetNewLocation
	{
		[TestMethod]
		public void Exception001()
		{
			var boundaryMin = new Model.Location(0, 0);
			var boundaryMax = new Model.Location(1, 1);

			Assert.ThrowsException<BoundaryBreachedException>(() => boundaryMin.GetNewLocation(new Model.Location(2, 2), boundaryMax, boundaryMin, boundaryMax));
		}

		[TestMethod]
		public void Success001()
		{
			var boundaryMin = new Model.Location(0, 0);
			var boundaryMax = new Model.Location(1, 1);

			Assert.AreEqual(boundaryMax, boundaryMin.GetNewLocation(boundaryMax, boundaryMax, boundaryMin, boundaryMax));
		}
	}
}
