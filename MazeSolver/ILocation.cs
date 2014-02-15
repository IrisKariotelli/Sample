using System;

namespace MazeSolver
{

	public interface ILocation{
		int Row{ get; }
		int Column{ get; }
		bool CanStepInto();
		bool IsStart();
		bool IsEnd();
	}
	
}
