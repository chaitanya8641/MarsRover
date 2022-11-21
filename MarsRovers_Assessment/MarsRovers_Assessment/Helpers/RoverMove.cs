using MarsRovers_Assessment.Models;

namespace MarsRovers_Assessment.Helpers
{
    public static class RoverMove
    {
        public static string Move(RoverModel roverModel, string roverCommand)
        {
            char[] instructions = roverCommand.ToCharArray();
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        RoverCommand.TurnLeft(roverModel.Rover);
                        break;
                    case 'R':
                        RoverCommand.TurnRight(roverModel.Rover);
                        break;
                    case 'M':
                        RoverCommand.MoveForward(roverModel.Rover);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            if (roverModel.Rover.PositonX > roverModel.X_Coordinate || roverModel.Rover.PositionY > roverModel.Y_Coordinate)
            {
               return "Specified argument was out of the range of valid values.";
            }
               
            return roverModel.Rover.PositonX + " " + roverModel.Rover.PositionY + " " + roverModel.Rover.Direction;
        }
    }
}
