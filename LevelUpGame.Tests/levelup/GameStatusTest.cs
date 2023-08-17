
using NUnit.Framework;
using levelup.cli;

namespace levelup;

[TestFixture]
public class GameStatusTest {
    private readonly string CharacterName = "ALIEN";
    private GameStatus _gameStatus;

    [SetUp]
    public void SetUp() {
        _gameStatus = new GameStatus(CharacterName);
    }

    [Test]
    public void GameStatusHasCharacterName() {
        Assert.AreEqual(CharacterName, _gameStatus.CharacterName);
    }

}