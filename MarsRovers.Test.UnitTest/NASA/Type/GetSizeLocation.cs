using MarsRovers.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRovers.Test.UnitTest.NASA.Type
{

	[TestClass]
	public class GetSizeLocation
	{

		[TestMethod]
		public void SuccessE()
		{
			Assert.AreEqual(new Model.Location(1, 0), Model.NASA.GetSizeLocation(CardinalCompassPoint.East));
		}

		[TestMethod]
		public void SuccessN()
		{
			Assert.AreEqual(new Model.Location(0, 1), Model.NASA.GetSizeLocation(CardinalCompassPoint.North));
		}

		[TestMethod]
		public void SuccessS()
		{
			Assert.AreEqual(new Model.Location(0, -1), Model.NASA.GetSizeLocation(CardinalCompassPoint.South));
		}

		[TestMethod]
		public void SuccessW()
		{
			Assert.AreEqual(new Model.Location(-1, 0), Model.NASA.GetSizeLocation(CardinalCompassPoint.West));
		}

	}

}
