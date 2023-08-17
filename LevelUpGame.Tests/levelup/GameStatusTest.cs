
using NUnit.Framework;
using levelup.cli;

namespace levelup;

[TestFixture]
public class GameStatusTest {
    private readonly string CharacterName = "ALIEN";
    private GameStatus _gameStatus;
    private Position _position;

    [SetUp]
    public void SetUp() {
        _position = new Position();
        _gameStatus = new GameStatus(CharacterName, _position);
    }

    [Test]
    public void GameStatusHasCharacterName() {
        Assert.AreEqual(CharacterName, _gameStatus.CharacterName);
    }

    [Test]
    public void GameStatusHasPosition() {
        Assert.NotNull(_gameStatus.Position);
    }
    

}