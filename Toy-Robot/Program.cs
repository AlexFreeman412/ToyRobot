using System;
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
                        int x = Convert.ToInt32(parameters.Split(new char[] { ',' }, 3)[0]);
                        int y = Convert.ToInt32(parameters.Split(new char[] { ',' }, 3)[1]);
                        var direction = parameters.Split(new char[] { ',' }, 3)[2];
                        placeRobot(x, y, direction);
                        break;
                    case "REPORT":
                        report();
                        break;
                    case "EXIT":
                        exitNextLoop = true;
                        break;
                    default:
                        //TODO: Error 
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

        private static bool report()
        {
            if (robot == null)
            {
                return false;
            }

            Console.WriteLine(robot.Report());
            return true;
        }

       
    }
}
