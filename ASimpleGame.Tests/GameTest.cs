namespace ASimpleGame.Tests
{
    public class GameTest
    {
        [Fact]
        public void testDefaultMove()
        {
            Game game = new Game("XOXOX-OXO");
            Assert.Equal(5, game.Move('X'));

            game = new Game("XOXOXOOX-");
            Assert.Equal(8, game.Move('O'));

            game = new Game("---------");
            Assert.Equal(0, game.Move('X'));

            game = new Game("XXXXXXXXX");
            Assert.Equal(-1, game.Move('X'));
        }

        [Fact]
        public void testFindWinningMove()
        {
            Game game = new Game("XO-XX-OOX");
            Assert.Equal(5, game.Move('X'));
        }

        [Fact]
        public void testWinConditions()
        {
            Game game = new Game("---XXX---");
            Assert.Equal('X', game.Winner());
        }
    }
}