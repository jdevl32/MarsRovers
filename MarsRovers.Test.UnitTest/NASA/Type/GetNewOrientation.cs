using MarsRovers.Model;
using MarsRovers.Model.Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRovers.Test.UnitTest.NASA.Type
{

	[TestClass]
	public class GetNewOrientation
	{

		[TestMethod]
		public void Exception001()
		{
			Assert.ThrowsException<InvalidInstructionException>(() => Model.NASA.GetNewOrientation(char.MaxValue, char.MaxValue));
		}

		[TestMethod]
		public void SuccessEEM()
		{
			Assert.AreEqual(CardinalCompassPoint.East, Model.NASA.GetNewOrientation(CardinalCompassPoint.East, NavigationInstruction.MoveForward));
		}

		[TestMethod]
		public void SuccessNEL()
		{
			Assert.AreEqual(CardinalCompassPoint.North, Model.NASA.GetNewOrientation(CardinalCompassPoint.East, NavigationInstruction.PivotLeft));
		}

		[TestMethod]
		public void SuccessSER()
		{
			Assert.AreEqual(CardinalCompassPoint.South, Model.NASA.GetNewOrientation(CardinalCompassPoint.East, NavigationInstruction.PivotRight));
		}

		[TestMethod]
		public void SuccessNNM()
		{
			Assert.AreEqual(CardinalCompassPoint.North, Model.NASA.GetNewOrientation(CardinalCompassPoint.North, NavigationInstruction.MoveForward));
		}

		[TestMethod]
		public void SuccessWNL()
		{
			Assert.AreEqual(CardinalCompassPoint.West, Model.NASA.GetNewOrientation(CardinalCompassPoint.North, NavigationInstruction.PivotLeft));
		}

		[TestMethod]
		public void SuccessENR()
		{
			Assert.AreEqual(CardinalCompassPoint.East, Model.NASA.GetNewOrientation(CardinalCompassPoint.North, NavigationInstruction.PivotRight));
		}

		[TestMethod]
		public void SuccessSSM()
		{
			Assert.AreEqual(CardinalCompassPoint.South, Model.NASA.GetNewOrientation(CardinalCompassPoint.South, NavigationInstruction.MoveForward));
		}

		[TestMethod]
		public void SuccessESL()
		{
			Assert.AreEqual(CardinalCompassPoint.East, Model.NASA.GetNewOrientation(CardinalCompassPoint.South, NavigationInstruction.PivotLeft));
		}

		[TestMethod]
		public void SuccessWSR()
		{
			Assert.AreEqual(CardinalCompassPoint.West, Model.NASA.GetNewOrientation(CardinalCompassPoint.South, NavigationInstruction.PivotRight));
		}

		[TestMethod]
		public void SuccessWWM()
		{
			Assert.AreEqual(CardinalCompassPoint.West, Model.NASA.GetNewOrientation(CardinalCompassPoint.West, NavigationInstruction.MoveForward));
		}

		[TestMethod]
		public void SuccessSWL()
		{
			Assert.AreEqual(CardinalCompassPoint.South, Model.NASA.GetNewOrientation(CardinalCompassPoint.West, NavigationInstruction.PivotLeft));
		}

		[TestMethod]
		public void SuccessNWR()
		{
			Assert.AreEqual(CardinalCompassPoint.North, Model.NASA.GetNewOrientation(CardinalCompassPoint.West, NavigationInstruction.PivotRight));
		}

	}

}
