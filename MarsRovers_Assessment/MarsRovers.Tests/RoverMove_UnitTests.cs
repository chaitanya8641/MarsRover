using MarsRovers_Assessment.Helpers;
using MarsRovers_Assessment.Models;

namespace MarsRovers.Tests
{
    public class RoverMove_UnitTests
    {
        [Fact]
        public void Rover_ValidInput_Test1()
        {
            RoverModel roverModel = new();
            roverModel.X_Coordinate = 5;
            roverModel.Y_Coordinate = 5;
            roverModel.Rover = RoverPositions.RoverPositionsListModel("1 2 N");
            var location = RoverMove.Move(roverModel, "LMLMLMLMM");
            Assert.True(location == "1 3 N");
        }

        [Fact]
        public void Rover_ValidInput_Test2()
        {
            RoverModel roverModel = new();
            roverModel.X_Coordinate = 5;
            roverModel.Y_Coordinate = 5;
            roverModel.Rover = RoverPositions.RoverPositionsListModel("3 3 E");
            var location = RoverMove.Move(roverModel, "MMRMMRMRRM");
            Assert.True(location == "5 1 E");
        }

        [Fact]
        public void Rover_InValidInput_Test3()
        {
            RoverModel roverModel = new();
            roverModel.X_Coordinate = 5;
            roverModel.Y_Coordinate = 5;
            roverModel.Rover = RoverPositions.RoverPositionsListModel("3 3 E");
            var errorMessage = RoverMove.Move(roverModel, "MMMMMMMMMMMM");
            Assert.Equal("Specified argument was out of the range of valid values.",errorMessage);
        }
    }
}