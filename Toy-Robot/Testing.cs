using System;
namespace ToyRobot
{
    public class Testing
    {
        public Testing()
        {
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
            Test6();
            Test7();
            Console.ReadKey();
        }

        public void Test1()
        {
            Console.WriteLine("******* TEST 1 *******");
            Console.WriteLine();

            Console.WriteLine("Instructions:");
            Console.WriteLine("PLACE 0,0,NORTH");
            Console.WriteLine("MOVE");
            Console.WriteLine("REPORT");
            Console.WriteLine();

            Console.WriteLine("Expected Output:");
            Console.WriteLine("0,1,NORTH");
            Console.WriteLine();

            Console.WriteLine("Actual Output:");
            Program.PlaceRobot(0, 0, "NORTH");
            Program.MoveRobot();
            Program.Report();
            Console.WriteLine();
        }

        public void Test2()
        {
            Console.WriteLine("******* TEST 2 *******");
            Console.WriteLine();

            Console.WriteLine("Instructions:");
            Console.WriteLine("PLACE 0,0,NORTH");
            Console.WriteLine("LEFT");
            Console.WriteLine("REPORT");
            Console.WriteLine();

            Console.WriteLine("Expected Output:");
            Console.WriteLine("0,0,WEST");
            Console.WriteLine();

            Console.WriteLine("Actual Output:");
            Program.PlaceRobot(0, 0, "NORTH");
            Program.RotateRobotLeft();
            Program.Report();
            Console.WriteLine();
        }

        public void Test3()
        {
            Console.WriteLine("******* TEST 3 *******");
            Console.WriteLine();

            Console.WriteLine("Instructions:");
            Console.WriteLine("PLACE 1,2,EAST");
            Console.WriteLine("MOVE");
            Console.WriteLine("MOVE");
            Console.WriteLine("LEFT");
            Console.WriteLine("MOVE");
            Console.WriteLine("REPORT");
            Console.WriteLine();

            Console.WriteLine("Expected Output:");
            Console.WriteLine("3,3,NORTH");
            Console.WriteLine();

            Console.WriteLine("Actual Output:");
            Program.PlaceRobot(1, 2, "EAST");
            Program.MoveRobot();
            Program.MoveRobot();
            Program.RotateRobotLeft();
            Program.MoveRobot();
            Program.Report();
            Console.WriteLine();
        }

        public void Test4()
        {
            Console.WriteLine("******* TEST 4 *******");
            Console.WriteLine();

            Console.WriteLine("Instructions:");
            Console.WriteLine("PLACE 4,4,NORTH");
            Console.WriteLine("MOVE"); // Fails.
            Console.WriteLine("LEFT");
            Console.WriteLine("MOVE");
            Console.WriteLine("REPORT");
            Console.WriteLine();

            Console.WriteLine("Expected Output:");
            Console.WriteLine("Appropriate error message");
            Console.WriteLine("3,4,WEST");
            Console.WriteLine();

            Console.WriteLine("Actual Output:");
            Program.PlaceRobot(4, 4, "NORTH");
            Program.MoveRobot();
            Program.RotateRobotLeft();
            Program.MoveRobot();
            Program.Report();
            Console.WriteLine();
        }

        public void Test5()
        {
            Console.WriteLine("******* TEST 5 *******");
            Console.WriteLine();

            Console.WriteLine("Instructions:");
            Console.WriteLine("PLACE 1,1,WEST");
            Console.WriteLine("MOVE"); 
            Console.WriteLine("MOVE"); // Fails.
            Console.WriteLine("REPORT");
            Console.WriteLine();

            Console.WriteLine("Expected Output:");
            Console.WriteLine("Appropriate error message");
            Console.WriteLine("0,1,WEST");
            Console.WriteLine();

            Console.WriteLine("Actual Output:");
            Program.PlaceRobot(1, 1, "WEST");
            Program.MoveRobot();
            Program.MoveRobot();
            Program.Report();
            Console.WriteLine();
        }

        public void Test6()
        {
            Console.WriteLine("******* TEST 6 *******");
            Console.WriteLine();

            Console.WriteLine("Instructions:");
            Console.WriteLine("PLACE 10,10,WEST");
            Console.WriteLine("REPORT");
            Console.WriteLine();

            Console.WriteLine("Expected Output:");
            Console.WriteLine("Appropriate error message");
            Console.WriteLine("Message saying there is no robot on the table");
            Console.WriteLine();

            Console.WriteLine("Actual Output:");
            Program.PlaceRobot(10, 10, "WEST");
            Program.Report();
            Console.WriteLine();
        }

        public void Test7()
        {
            Console.WriteLine("******* TEST 7 *******");
            Console.WriteLine();

            Console.WriteLine("Instructions:");
            Console.WriteLine("PLACE 2,3,SOUTH");
            Console.WriteLine("PLACE 2,2,EAST");
            Console.WriteLine("MOVE");
            Console.WriteLine("MOVE");
            Console.WriteLine("RIGHT");
            Console.WriteLine("MOVE");
            Console.WriteLine("REPORT");
            Console.WriteLine();

            Console.WriteLine("Expected Output:");
            Console.WriteLine("4,1,SOUTH");
            Console.WriteLine();

            Console.WriteLine("Actual Output:");
            Program.PlaceRobot(2, 3, "SOUTH");
            Program.PlaceRobot(2, 2, "EAST");
            Program.MoveRobot();
            Program.MoveRobot();
            Program.RotateRobotRight();
            Program.MoveRobot();
            Program.Report();
            Console.WriteLine();
        }

    }
}
