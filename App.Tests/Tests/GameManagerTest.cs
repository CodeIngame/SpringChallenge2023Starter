using App.Manager;
using Shouldly;

namespace App.Tests.Tests
{
    public class GameManagerTest
    {
        [Fact]
        public void Game_Should_Be_Instanciated()
        {
            var gameManager = new GameManager();
            gameManager.Game.ShouldNotBeNull();
        }
    }
}