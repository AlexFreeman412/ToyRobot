using System;
namespace ToyRobot
{
    public class Robot
    {
        private int xPos; // valid x coordinate positions are 0 - 5
        private int yPos; // valid y coordinate positions are 0 - 5
        private Direction direction;

        public Robot()
        {
        }

        public bool Place(int x, int y, Direction facing)
        {
            if (x < 0 || x > 5 || y < 0 || y > 5)
                return false;

            xPos = x;
            yPos = y;
            direction = facing;

            return true;
        }

        public Report Report()
        {
            return new Report(xPos, yPos, direction);
        }

        public enum Direction
        {
            NORTH,
            EAST,
            SOUTH,
            WEST
        }

        
    }

    // Report is a helper class to make it easier to pass back the values of x position, y position and direction when the Report method is called.
    public class Report
    {
        private int xPos; // valid x coordinate positions are 0 - 5
        private int yPos; // valid y coordinate positions are 0 - 5
        private Robot.Direction direction;

        public Report(int x, int y, Robot.Direction facing)
        {
            xPos = x;
            yPos = y;
            direction = facing;
        }
    }
}


