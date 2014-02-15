using System;

namespace MazeSolver
{

	public abstract class Location:ILocation{
		public Location( int row, int column ){
			Row = row;
			Column = column;
		}

		public int Row { get; private set; }

		public int Column { get;private set; }
	}
		
	public class Start:Location{
		public bool CanStepInto(){
			return true;
		}
		public bool IsStart(){
			return true;
		}
		//Making the assumption that Start & End have to be different or there's no fun
		public bool IsEnd(){
			return false;
		}
	}

	public class End:Location{
		public bool CanStepInto(){
			return true;
		}
		public bool IsStart(){
			return false;
		}
		//Making the assumption that Start & End have to be different or there's no fun
		public bool IsEnd(){
			return true;
		}
	}

	public class Empty:Location{
		public bool CanStepInto(){
			return true;
		}
		public bool IsStart(){
			return false;
		}
		//Making the assumption that Start & End have to be different or there's no fun
		public bool IsEnd(){
			return false;
		}
	}
	public class Wall:Location{
		public bool CanStepInto(){
			return false;
		}
		public bool IsStart(){
			return false;
		}
		//Making the assumption that Start & End have to be different or there's no fun
		public bool IsEnd(){
			return false;
		}
	}
	
}
