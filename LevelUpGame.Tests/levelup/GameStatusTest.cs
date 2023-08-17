
using NUnit.Framework;
using levelup.cli;

namespace levelup;

[TestFixture]
public class GameStatusTest {
    private readonly string CharacterName = "ALIEN";
    private readonly int ExpectedMoveCount = 1;
    private GameStatus _gameStatus;
    private Position _position;

    [SetUp]
    public void SetUp() {
        _position = new Position();
        _gameStatus = new GameStatus(CharacterName, _position, ExpectedMoveCount);
    }

    [Test]
    public void GameStatusHasCharacterName() {
        Assert.AreEqual(CharacterName, _gameStatus.CharacterName);
    }

    [Test]
    public void GameStatusHasPosition() {
        Assert.NotNull(_gameStatus.Position);
    }

    [Test]
    public void GameStatusHasMoveCount() {
        Assert.AreEqual(ExpectedMoveCount,_gameStatus.MoveCount);
    }

    [Test]
    public void GameStatusHasToString() {
        Assert.IsNotEmpty(_gameStatus.ToString());
    }
    

}