namespace MarsRovers_Assessment.Models
{
    public class RoverModel
    {
        public int X_Coordinate { get; set; } = 0;
        public int Y_Coordinate { get; set; } = 0;
        public Rover Rover { get; set; } = null!;

    }

    public class Rover
    {
        public int PositonX { get; set; } = 0;
        public int PositionY { get; set; } = 0;
        public string Direction { get; set; } = null!;
    }
}
