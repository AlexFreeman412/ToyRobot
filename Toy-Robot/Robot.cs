using System;
namespace ToyRobot
{
    public class Robot
    {
        private int xPos; // valid x coordinate positions are 0 - 4
        private int yPos; // valid y coordinate positions are 0 - 4
        private string direction;

        public Robot()
        {
        }

        // Places the robot on the table, if the robot is being placed off the table it will return false.
        public bool Place(int x, int y, string facing)
        {
            if (x < 0 || x > 4 || y < 0 || y > 4)
                return false;

            xPos = x;
            yPos = y;
            direction = facing;

            return true;
        }

        // Moves the robot one unit in the direction it is facing (unless that movement would move the robot off the table in which case it makes no movement and returns a value of false).
        public bool Move()
        {
            // Checks if the attempted move will move the robot off the table (eg. an x or y value of -1 or 5) and if so does not make the move. If it is a valid move then make the move and return true.
            // Valid x and y coordinates are 0-4 because instructions specify origin at 0,0 and a table of 5 units x 5 units.
            switch (direction)
            {
                case "NORTH":
                    if(yPos + 1 > 4)
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
                    if (xPos + 1 > 4)
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

        // Rotates the robot 90 degrees left (eg. if robot is facing NORTH it will face WEST after rotating)
        public bool Left()
        {
            switch (direction)
            {
                case "NORTH":
                    direction = "WEST";
                    break;
                case "WEST":
                    direction = "SOUTH";
                    break;
                case "SOUTH":
                    direction = "EAST";
                    break;
                case "EAST":
                    direction = "NORTH";
                    break;
                default:
                    // SHOULD NEVER HAPPEN
                    return false;
            }
            return true;
        }

        // Rotates the robot 90 degrees right (eg. if robot is facing NORTH it will face EAST after rotating)
        public bool Right()
        {
            switch (direction)
            {
                case "NORTH":
                    direction = "EAST";
                    break;
                case "EAST":
                    direction = "SOUTH";
                    break;
                case "SOUTH":
                    direction = "WEST";
                    break;
                case "WEST":
                    direction = "NORTH";
                    break;
                default:
                    // SHOULD NEVER HAPPEN
                    return false;
            }
            return true;
        }

        // Returns a string of the position of the robot along the x and y axis of the table and the direction the robot is facing in the format (x,y,direction).
        public string Report()
        {
            return xPos + "," + yPos + "," + direction;
        }

    }

}


