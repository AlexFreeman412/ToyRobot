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

        public bool Move()
        {
            // Checks if the attempted move will move the robot off the table (eg. an x or y value of -1 or 6) and if so does not make the move. If it is a valid move then make the move and return true.
            switch (direction)
            {
                case "NORTH":
                    if(yPos + 1 > 5)
                    {
                        return false;
                    }
                    else
                    {
                        yPos++;
                        return true;
                    }
                case "SOUTH":
                    if (yPos - 1 < 0)
                    {
                        return false;
                    }
                    else
                    {
                        yPos--;
                        return true;
                    }
                case "EAST":
                    if (xPos + 1 > 5)
                    {
                        return false;
                    }
                    else
                    {
                        xPos++;
                        return true;
                    }
                case "WEST":
                    if (xPos - 1 < 0)
                    {
                        return false;
                    }
                    else
                    {
                        xPos--;
                        return true;
                    }
                default:
                    // Should never happen!
                    return false;
            }
        }

        public string Report()
        {
            return xPos + "," + yPos + "," + direction;
        }

    }

}


