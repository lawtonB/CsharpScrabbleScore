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
  }
}
