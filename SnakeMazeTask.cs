namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            while (robot.Y < height - 2)
            {
                MoveRight(robot, width - 2);
                MoveDownTwoSteps(robot);
                MoveLeft(robot, width - 2);
                if (robot.Y < height - 2)
                    MoveDownTwoSteps(robot);
            }
		}

        private static void MoveRight(Robot robot, int steps)
        {
            for (var i = 1; i < steps; i++)
                robot.MoveTo(Direction.Right);
        }

        private static void MoveLeft(Robot robot, int steps)
        {
            for (var i = 1; i < steps; i++)
                robot.MoveTo(Direction.Left);
        }

        private static void MoveDownTwoSteps(Robot robot)
        {
            for (var i = 0; i < 2; i++)
                robot.MoveTo(Direction.Down);
        }
	}
}