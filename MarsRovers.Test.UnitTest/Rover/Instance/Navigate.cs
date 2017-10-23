using MarsRovers.Model;
using MarsRovers.Model.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MarsRovers.Test.UnitTest.Rover.Instance
{

	[TestClass]
	public class Navigate
	{
		private static Plateau Plateau { get; }

		private static Mock<ISquad> MockAllLocationsOccupied { get; }

		private static Mock<ISquad> MockNoLocationsOccupied { get; }

#region Type Initialization

		static Navigate()
		{
			MockAllLocationsOccupied = new Mock<ISquad>();
			MockNoLocationsOccupied = new Mock<ISquad>();
			Plateau = new Plateau(new Model.Location(0, 0), new Model.Location(5, 5));
		}

#endregion

		[TestInitialize]
		public void Initialize()
		{
			MockAllLocationsOccupied.Setup(squad => squad.IsLocationOccupied(It.IsAny<ILocation>())).Returns(true);
			MockNoLocationsOccupied.Setup(squad => squad.IsLocationOccupied(It.IsAny<ILocation>())).Returns(false);
		}

		[TestMethod]
		public void Success001()
		{
			var rover = new Model.Rover(1, "LMLMLMLMM", new Position(new Model.Location(1, 2), CardinalCompassPoint.North), MockNoLocationsOccupied.Object);

			rover.Navigate(Plateau);
			Assert.IsTrue("1 3 N" == rover.Position.ToString());
		}

		[TestMethod]
		public void Success002()
		{
			var rover = new Model.Rover(1, "MMRMMRMRRM", new Position(new Model.Location(3, 3), CardinalCompassPoint.East), MockNoLocationsOccupied.Object);

			rover.Navigate(Plateau);
			Assert.IsTrue("5 1 E" == rover.Position.ToString());
		}

	}

}
