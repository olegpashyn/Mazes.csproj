namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            MoveHorizontally(robot, width - 2);
            MoveVertically(robot, height - 2);
		}

        private static void MoveHorizontally(Robot robot, int steps)
        {
			for (var i = 1; i < steps; i++)
				robot.MoveTo(Direction.Right);
        }

        private static void MoveVertically(Robot robot, int steps)
        {
            for (var i = 1; i < steps; i++)
                robot.MoveTo(Direction.Down);
        }
	}
}