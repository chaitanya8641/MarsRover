using MarsRovers_Assessment.Models;

namespace MarsRovers_Assessment.Helpers
{
    public static class RoverPositions
    {
        public static Rover RoverPositionsListModel(string roverPositions)
        {
            var positions = roverPositions?.Split(" ");
            if (positions?.Length != 2)
            {
                var rover = new Rover
                {
                    PositonX = Convert.ToInt32(positions[0]),
                    PositionY = Convert.ToInt32(positions[1]),
                    Direction = positions[2]
                };

                return rover;
            }
            return new Rover();
        }
    }
}
