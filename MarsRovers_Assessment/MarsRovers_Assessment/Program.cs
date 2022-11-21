using MarsRovers_Assessment.Helpers;
using MarsRovers_Assessment.Models;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverModel roverModel = new();
            Console.WriteLine();
            Console.WriteLine(" Please Enter the maximum coordinates,two Rover's positions and message");
            Console.WriteLine();
            Console.WriteLine(" Example:\n Co-ordinates:5 5\n Rover 1 Positions:1 2 N\n Rover 1 Message:LMLMLMLMM\n Rover 2 Positions: 3 3 E\n Rover 2 Message:MMRMMRMRRM");
            Console.WriteLine();

            Console.Write("Co-ordinates: ");
            var maxCoordinates = Console.ReadLine();
            roverModel.X_Coordinate = Convert.ToInt32(maxCoordinates.Split(" ")[0]);
            roverModel.Y_Coordinate = Convert.ToInt32(maxCoordinates.Split(" ")[1]);

            Console.Write("Rover 1 Positions: ");
            var rover1Positions = Console.ReadLine();
            Console.Write("Rover 1 Message ");
            var rover1Command = Console.ReadLine();

            Console.Write("Rover 2 Positions: ");
            var rover2Positions = Console.ReadLine();
            Console.Write("Rover 2 Message ");
            var rover2Command = Console.ReadLine();

            roverModel.Rover = RoverPositions.RoverPositionsListModel(rover1Positions);
            Console.WriteLine(RoverMove.Move(roverModel,rover1Command));
            roverModel.Rover = RoverPositions.RoverPositionsListModel(rover2Positions);
            Console.WriteLine(RoverMove.Move(roverModel, rover2Command));
            Console.ReadKey();
        }
    }
}