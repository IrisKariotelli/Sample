using NUnit.Framework;
using System;
using MazeSolver;

namespace MazeSolverTests
{
	[TestFixture ()]
	public class SampleTests
	{
		[Test ()]
		public void PrintsHello ()
		{
			var traverser = new MazeTraverser ();
			Assert.IsTrue(traverser.FreeAhead());

		}
	}
}

