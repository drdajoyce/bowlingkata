using NUnit.Framework;

namespace BowlingKata.Test
{
    public class Tests
    {
        [TestCase(1,1)]
        [TestCase(5, 5)]
        [TestCase(0, 0)]
        public void WhenAPlayerHitsSomePins_ScoreIsEqualToThat(int pins, int expectedScore)
        {
            //Arrange
            var newGameInstance = new BowlingKata.Game();

            //Act
            newGameInstance.Roll(pins);
            var actualScore = newGameInstance.Score();

            //Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

      

        [TestCase(3,3,6)]
        [TestCase(6, 4, 10)]
        public void WhenAPlayerHits3and3_ScoreIsEqualto6(int firstRollPins,int secondRollPins, int expectedScore)
        {
           
            //Arrange
            var newGameInstance = new BowlingKata.Game();

            //Act
            newGameInstance.Roll(firstRollPins);
            newGameInstance.Roll(secondRollPins);
            var score = newGameInstance.Score();

            //Assert
            Assert.AreEqual(expectedScore, score);
        }


    }
}