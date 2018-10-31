using System;
using System.Text.RegularExpressions;

namespace ToyRobot
{
    class Program
    {
        public static Robot robot;
        private static bool exitNextLoop = false;

        static void Main()
        {
            while (!exitNextLoop)
            { 
                Console.WriteLine("Type your command");

                var input = Console.ReadLine();

                // Takes the first word in the input (eg. the characters up to the first space)
                var command = input.Split(new char[] { ' ' }, 2)[0];

                // Code for each command has been seperated into methods for readability purposes
                switch (command)
                {
                    case "PLACE":
                        // Checks that something follows the PLACE command and if not shows an error message
                        if(input.Split(new char[] { ' ' }, 2).Length < 2)
                        {
                           Console.WriteLine("The PLACE command must be followed by an x coordinate, y coordinate and direction seperated by commas (eg. 1,2,NORTH)");
                        }
                        else
                        {
                            // Gets the x, y and directional input from the input string and stores them in individual variables
                            var parameters = input.Split(new char[] { ' ' }, 2)[1];

                            if (validatePLACEParameters(parameters))
                            {
                                int x = Convert.ToInt32(parameters.Split(new char[] { ',' }, 3)[0]);
                                int y = Convert.ToInt32(parameters.Split(new char[] { ',' }, 3)[1]);
                                var direction = parameters.Split(new char[] { ',' }, 3)[2];
                                placeRobot(x, y, direction);
                            }
                            else
                            {
                                Console.WriteLine("The PLACE command must be followed by an x coordinate, y coordinate and direction seperated by commas (eg. 1,2,NORTH)");
                            }
                        }                        
                        break;
                    case "MOVE":
                        moveRobot();
                        break;
                    case "LEFT":
                        rotateRobotLeft();
                        break;
                    case "RIGHT":
                        rotateRobotRight();
                        break;
                    case "REPORT":
                        report();
                        break;
                    case "HELP":
                        printHelp();
                        break;
                    case "EXIT":
                        exitNextLoop = true;
                        break;
                    default:
                        Console.WriteLine(input + " is not a valid command.");
                        break;
                }

                Console.WriteLine();
            }
            
        }

        // If there is no robot on the table this places the robot at the specified position facing the specified direction. 
        // If there is already a robot on the table this changes the robots position and facing direction to those specified.
        private static bool placeRobot(int x, int y, string direction)
        {
            if(robot == null)
            {
                robot = new Robot();
            }

            robot.Place(x, y, direction);
            return true;
        }

        // Attempts to move the robot based on its current facing position and gives the appropriate message if not able to.
        private static bool moveRobot()
        {
            if (robot == null)
            {
                Console.WriteLine("No robot on table");
                return false;
            }

            if (!robot.Move())
            {
                Console.WriteLine("Robot can not move off of the table. Type REPORT to see where the robot is currently positioned.");
                return false;
            }

            return true;
        }

        // Attempts to rotate the robot left and gives the appropriate message if not able to.
        private static bool rotateRobotLeft()
        {
            if (robot == null)
            {
                Console.WriteLine("No robot on table");
                return false;
            }

            return robot.Left();
        }

        // Attempts to rotate the robot right and gives the appropriate message if not able to.
        private static bool rotateRobotRight()
        {
            if (robot == null)
            {
                Console.WriteLine("No robot on table");
                return false;
            }

            return robot.Right();
        }

        // Attempts to generate and display a report showing the robots current x and y positions and it's facing direction in the following format "x,y,direction" and gives the appropriate message if not able to. 
        private static bool report()
        {
            if (robot == null)
            {
                Console.WriteLine("No robot on table");
                return false;
            }

            Console.WriteLine(robot.Report());
            return true;
        }

        // This method just prints some instructions of valid commands for the user's reference.
        private static void printHelp()
        {
            Console.WriteLine("The following are valid commands: ");
            Console.WriteLine("PLACE x,y,DIRECTION - places the robot on the table at the specified location and facing the specified direction (eg. PLACE 1,2,NORTH).");
            Console.WriteLine("Valid x coordinates are 0-4.");
            Console.WriteLine("Valid x coordinates are 0-4.");
            Console.WriteLine("Valid directions are NORTH, EAST, SOUTH and WEST.");
            Console.WriteLine("MOVE - Moves the robot based on which direction it is currently facing.");
            Console.WriteLine("LEFT - Rotates the robot to face in the direction left of where it is currently facing.");
            Console.WriteLine("RIGHT - Rotates the robot to face in the direction right of where it is currently facing.");
            Console.WriteLine("REPORT - Shows the robots current location and which direction it is facing in the format x,y,DIRECTION.");
            Console.WriteLine("HELP - Displays this help information.");
            Console.WriteLine("EXIT - Exits the application.");
        }

        // Following a PLACE command we expect input in the format of a x coordinate, y coordinate and valid direction seperated by commas (eg. PLACE 1,2,NORTH).
        // The following code checks to ensure we have received valid input and if not returns false. 
        private static bool validatePLACEParameters(string parameters)
        {
            bool isOK = Regex.IsMatch(parameters, @"[0-9]\,[0-9]\,");
            if (!isOK)
            {
                return false;
            }
            int n;
            var xisNumeric = int.TryParse(parameters.Split(new char[] { ',' }, 3)[0], out n);
            int z;
            var yisNumeric = int.TryParse(parameters.Split(new char[] { ',' }, 3)[1], out z);
            var direction = parameters.Split(new char[] { ',' }, 3)[2];

            if(!xisNumeric || !yisNumeric || (!direction.Equals("NORTH") && !direction.Equals("SOUTH") && !direction.Equals("EAST") && !direction.Equals("WEST")))
            {
                return false;
            }

            return true;
        }

       
    }
}
