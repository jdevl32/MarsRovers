using MarsRovers.Model.Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRovers.Test.UnitTest.Coordinate
{
	[TestClass]
	public class FromMove
	{
		[TestMethod]
		public void Exception1111() => Assert.ThrowsException<BoundaryBreachedException>(() => new Model.Coordinate {Value = 1}.FromMove(1, 1, 1));

		[TestMethod]
		public void Exception1234() => Assert.ThrowsException<BoundaryBreachedException>(() => new Model.Coordinate {Value = 1}.FromMove(2, 3, 4));

		[TestMethod]
		public void Success1112() => Assert.AreEqual(2, new Model.Coordinate { Value = 1 }.FromMove(1, 1, 2));
	}
}
