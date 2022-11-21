using MarsRovers_Assessment.Models;

namespace MarsRovers_Assessment.Helpers
{
    public static class RoverCommand
    {
        public static void TurnLeft(Rover roverModel)
        {
            switch (roverModel.Direction)
            {
                case "N":
                    roverModel.Direction = "W";
                    break;

                case "W":
                    roverModel.Direction = "S";
                    break;

                case "S":
                    roverModel.Direction = "E";
                    break;

                case "E":
                    roverModel.Direction = "N";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static void TurnRight(Rover roverModel)
        {
            switch (roverModel.Direction)
            {
                case "N":
                    roverModel.Direction = "E";
                    break;

                case "W":
                    roverModel.Direction = "N";
                    break;

                case "S":
                    roverModel.Direction = "W";
                    break;

                case "E":
                    roverModel.Direction = "S";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static void MoveForward(Rover roverModel)
        {
            switch (roverModel.Direction)
            {
                case "N":
                    roverModel.PositionY += 1;
                    break;

                case "E":
                    roverModel.PositonX += 1;
                    break;

                case "W":
                    roverModel.PositonX -= 1;
                    break;

                case "S":
                    roverModel.PositionY -= 1;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
