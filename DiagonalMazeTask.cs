using System.Runtime.InteropServices;

namespace Mazes
{
	public static class DiagonalMazeTask
    {
        private static int _innerWidth;
        private static int _innerHeight;
        private static int _vertStep;
        private static int _horStep;
        private static bool _highMaze;

		public static void MoveOut(Robot robot, int width, int height)
        {
            _innerWidth = width - 2;
            _innerHeight = height - 2;
            EstablishSteps();
            if (_highMaze)
                MoveFirstDown(robot);
            else
                MoveFirstRight(robot);
        }

        private static void EstablishSteps()
        {
            if (_innerWidth < _innerHeight)
            {
                _vertStep = ((_innerHeight - 1) / (_innerWidth - 1));
                _horStep = 1;
                _highMaze = true;
            }
            else
            {
                _horStep = ((_innerWidth - 1) / (_innerHeight - 1));
                _vertStep = 1;
            }
        }

        private static void MoveRight(Robot robot)
        {
            for (var i = 0; i < _horStep; i++)
                robot.MoveTo(Direction.Right);
        }

        private static void MoveDown(Robot robot)
        {
            for (var i = 0; i < _vertStep; i++)
                robot.MoveTo(Direction.Down);
        }

        private static void MoveFirstRight(Robot robot)
        {
            while (robot.X < _innerWidth) 
            {
                MoveRight(robot);
                if (robot.Y < _innerHeight) MoveDown(robot);
            }
        }

        private static void MoveFirstDown(Robot robot)
        {
            while (robot.Y < _innerHeight)
            {
                MoveDown(robot);
                if (robot.X < _innerWidth) MoveRight(robot);
            }
        }
	}
}