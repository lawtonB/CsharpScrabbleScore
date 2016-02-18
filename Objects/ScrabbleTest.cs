using System.Collections.Generic;
using Xunit;
using Scrabblenamespace;


namespace  Scrabblenamespace
{
  public class ScrabblesTest
  {
    [Fact]
    public void Test1_DogHouse_true()
    {
      string testword = "A";
      Assert.Equal (1, Scrabble.DogHouse(testword));
    }

    [Fact]
    public void Test1_DogHouse_IsUpperCaseTrue()
      {
      string testword = "e";
      Assert.Equal (1, Scrabble.DogHouse(testword));
      }
  [Fact]
  public void Test1_DogHouse_IsScoreTrue()
    {
    string testword = "AEI";
    Assert.Equal (3, Scrabble.DogHouse(testword));
    }
  }
}
