using Xunit;
using System;
using FluentAssertions;
using CSharpGames;
using Moq;

namespace CSharpGames.Test;

[Collection("Sequential")]
public class TestCSharpGamesDatabase
{
    // 10. Implemente os testes da funcionalidade de buscar jogos jogados por uma pessoa jogadora
    [Theory(DisplayName = "Deve testar se GetGamesPlayedBy retorna jogos jogados pela pessoa jogadora corretamente.")]
    [MemberData(nameof(DataTestGetGamesPlayedBy))]
    public void TestGetGamesPlayedBy(CSharpGamesDatabase databaseEntry, int playerIdEntry, List<Game> expected)
    {
        throw new NotImplementedException();

        // Arrange
        
        // AcT

        // Assert
    }

    public static TheoryData<CSharpGamesDatabase, int, List<Game>> DataTestGetGamesPlayedBy => new TheoryData<CSharpGamesDatabase, int, List<Game>>
    {
        {
            new CSharpGamesDatabase
            {
                Games = new List<Game>
                {
                    new Game
                    {
                        Id = 1,
                        Name = "Teste",
                        DeveloperStudio = 1,
                        Players = new List<int> { 1 }
                    }
                },
                GameStudios = new List<GameStudio>
                {
                    new GameStudio
                    {
                        Id = 1,
                        Name = "Teste"
                    }
                },
                Players = new List<Player>
                {
                    new Player
                    {
                        Id = 1,
                        Name = "Teste",
                        GamesOwned = new List<int> { 1 }
                    }
                }
            },
            1,
            new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Name = "Teste",
                    DeveloperStudio = 1,
                    Players = new List<int> { 1 }
                }
            }
        }
    };

}
