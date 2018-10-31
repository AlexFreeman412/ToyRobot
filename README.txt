TOY ROBOT PROGRAM

The program encompasses a table that is 5 units by 5 units and a robot that can be placed on the table and moved around. The table has x coordinates ranging from 0-4 and y coordinates ranging from 0-4. 

The robot can be turned to face any direction out of NORTH,WEST,SOUTH and EAST and can be moved one unit in the direction it is facing (see below for a list of valid commands). At any time the user can generate a report showing the robots current x and y position as well as the direction it is currently facing.

You can not place the robot outside of the table or make a move that would result in the robot falling off the table. 

The following are valid commands:
PLACE x,y,DIRECTION - places the robot on the table at the specified location and facing the specified direction (eg. PLACE 1,2,NORTH).
Valid x coordinates are 0-4.
Valid x coordinates are 0-4.
Valid directions are NORTH, EAST, SOUTH and WEST.
MOVE - Moves the robot based on which direction it is currently facing.
LEFT - Rotates the robot to face in the direction left of where it is currently facing.
RIGHT - Rotates the robot to face in the direction right of where it is currently facing.
REPORT - Shows the robots current location and which direction it is facing in the format x,y,DIRECTION.
HELP - Displays this help information.
EXIT - Exits the application.