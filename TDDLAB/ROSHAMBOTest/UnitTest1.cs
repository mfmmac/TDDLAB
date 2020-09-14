using ROSHAMBO;
using System;
using Xunit;

namespace ROSHAMBOTest
{
    public class RockPaperScissorsTest
    {
            [Fact]
            public void RockBeatsScissorsTest()
            {
                //Arrange
                Roshambo roshambo = new Roshambo();
                var playerOne = "Rock";
                var playerTwo = "Scissors";
                var expected = "Rock Wins!";

                //Act
                var actual = roshambo.Play(playerOne, playerTwo);

                //Assert
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void ScissorsBeatsPaperTest()
            {
                //Arrange
                Roshambo roshambo = new Roshambo();
                var playerOne = "Scissors";
                var playerTwo = "Paper";
                var expected = "Scissors Wins!";

                //Act
                var actual = roshambo.Play(playerOne, playerTwo);

                //Assert
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void PaperBeatsRockTest()
            {
                //Arrange
                Roshambo roshambo = new Roshambo();
                var playerOne = "Paper";
                var playerTwo = "Rock";
                var expected = "Paper Wins!";

                //Act
                var actual = roshambo.Play(playerOne, playerTwo);

                //Assert
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void ReturnsATieTest()
            {
                //Arrange
                Roshambo roshambo = new Roshambo();
                var playerOne = "Paper";
                var playerTwo = "Paper";
                var expected = "Tie!";

                //Act
                var actual = roshambo.Play(playerOne, playerTwo);

                //Assert
                Assert.Equal(expected, actual);
            }
    }
}
