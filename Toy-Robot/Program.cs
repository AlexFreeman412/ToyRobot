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
                        
                        break;
                    case "MOVE":
                        moveRobot();
                        break;
                    case "REPORT":
                        report();
                        break;
                    case "EXIT":
                        exitNextLoop = true;
                        break;
                    default:
                        Console.WriteLine(input + " is not a valid command.");
                        break;
                }
            }
            
        }

        private static bool placeRobot(int x, int y, string direction)
        {
            if(robot == null)
            {
                robot = new Robot();
            }

            robot.Place(x, y, direction);
            return true;
        }

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
