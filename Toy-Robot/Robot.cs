using System;
namespace ToyRobot
{
    public class Robot
    {
        private int xPos; // valid x coordinate positions are 0 - 5
        private int yPos; // valid y coordinate positions are 0 - 5
        private string direction;

        public Robot()
        {
        }

        public bool Place(int x, int y, string facing)
        {
            if (x < 0 || x > 5 || y < 0 || y > 5)
                return false;

            xPos = x;
            yPos = y;
            direction = facing;

            return true;
        }

        public string Report()
        {
            return xPos + "," + yPos + "," + direction;
        }

    }

}


