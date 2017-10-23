using MarsRovers.Model.Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRovers.Test.UnitTest.Location.Type
{
	[TestClass]
	public class GetNewCoordinate
	{
		[TestMethod]
		public void Exception001() => Assert.ThrowsException<BoundaryBreachedException>(() => Model.Location.GetNewCoordinate(1, 1, 1, 0, 1));

		[TestMethod]
		public void Exception002() => Assert.ThrowsException<BoundaryBreachedException>(() => Model.Location.GetNewCoordinate(1, 2, 3, 0, 4));

		[TestMethod]
		public void Exception003() => Assert.ThrowsException<BoundaryBreachedException>(() => Model.Location.GetNewCoordinate(1, -2, 1, 0, 1));

		[TestMethod]
		public void Success001() => Assert.AreEqual(2, Model.Location.GetNewCoordinate(1, 1, 1, 0, 2));

		[TestMethod]
		public void Success002() => Assert.AreEqual(0, Model.Location.GetNewCoordinate(1, -1, 1, 0, 1));
	}
}
