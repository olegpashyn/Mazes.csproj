using System.Runtime.InteropServices;

namespace Mazes
{
	public static class DiagonalMazeTask
    {
        private static int innerWidth;
        private static int innerHeight;
        private static int vertStep;
        private static int horStep;
        private static bool highMaze;

		public static void MoveOut(Robot robot, int width, int height)
        {
            innerWidth = width - 2;
            innerHeight = height - 2;
            EstablishSteps();
            if (highMaze)
                MoveFirstDown(robot);
            else
                MoveFirstRight(robot);
        }

        private static void EstablishSteps()
        {
            if (innerWidth <= innerHeight)
				HighMazeCase();
            else
            	LongMazeCase();
        }
		
		private static void HighMazeCase()
		{
             vertStep = (innerHeight / innerWidth);
             if (innerHeight - (vertStep * innerWidth) > (vertStep)) vertStep++;
             horStep = 1;
             highMaze = true;
        }
		
		private static void LongMazeCase()
		{
             horStep = (innerWidth / innerHeight);
             if (innerWidth - (horStep * innerHeight) > (horStep)) horStep++;
             vertStep = 1;
			 highMaze = false;
        }

        private static void MoveRight(Robot robot)
        {
            for (var i = 0; i < horStep; i++)
                robot.MoveTo(Direction.Right);
        }

        private static void MoveDown(Robot robot)
        {
            for (var i = 0; i < vertStep; i++)
                robot.MoveTo(Direction.Down);
        }

        private static void MoveFirstRight(Robot robot)
        {
            while (robot.X < innerWidth)
            {
                MoveRight(robot);
                if (robot.Y < innerHeight) MoveDown(robot);
            }
        }

        private static void MoveFirstDown(Robot robot)
        {
            while (robot.Y < innerHeight)
            {
                MoveDown(robot);
                if (robot.X < innerWidth) MoveRight(robot);
            }
        }
	}
}