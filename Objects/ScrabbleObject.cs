using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabblenamespace

{

  //variables//

    public class Scrabble
  {

//construtor//

  public Scrabble()
  {

  }

  public static int DogHouse(string word)
  {
    // char[] wordarray = word.ToCharArray();
    Dictionary<char, int> Allwords = new Dictionary<char, int> {};
      Allwords.Add('A', 1);
      Allwords.Add('E', 1);
      Allwords.Add('I', 1);
      Allwords.Add('O', 1);
      Allwords.Add('U', 1);
      Allwords.Add('L', 1);
      Allwords.Add('N', 1);
      Allwords.Add('R', 1);
      Allwords.Add('S', 1);
      Allwords.Add('T', 1);
      Allwords.Add('D', 2);
      Allwords.Add('G', 2);
      Allwords.Add('B', 3);
      Allwords.Add('M', 3);
      Allwords.Add('P', 3);
      Allwords.Add('F', 4);
      Allwords.Add('H', 4);
      Allwords.Add('V', 4);
      Allwords.Add('W', 4);
      Allwords.Add('Y', 4);
      Allwords.Add('K', 5);
      Allwords.Add('J', 8);
      Allwords.Add('X', 8);
      Allwords.Add('Q', 1);
      Allwords.Add('Z', 1);
      int score =0;

      string lowerWord = word.ToUpper();
     char[] Biggie = word.ToCharArray();
     for (int i = 0; i < Biggie.Length; i++) {
       foreach ( KeyValuePair<char, int> Tupac in Allwords) {
         if( Biggie[i] == Tupac.Key)
         {
           score += Tupac.Value;
         }
       }
     }

     return score;
   }
 }
}

// using System.Collections.Generic;
// using System;
//
// namespace ScrabbleScore.Objects
// {
//   public class ScrabbleScores
//   {
//
//
//     public ScrabbleScores()
//     {
//     }
//
//     public static int ScoreWord(string input)
//     {
//       Dictionary<char, int> testDictionary = new Dictionary<char, int> {};
//       testDictionary.Add('a', 1);
//       testDictionary.Add('e', 1);
//       testDictionary.Add('i', 1);
//       testDictionary.Add('o', 1);
//       testDictionary.Add('u', 1);
//       testDictionary.Add('l', 1);
//       testDictionary.Add('n', 1);
//       testDictionary.Add('r', 1);
//       testDictionary.Add('s', 1);
//       testDictionary.Add('t', 1);
//
//       testDictionary.Add('d', 2);
//       testDictionary.Add('g', 2);
//
//       testDictionary.Add('b', 3);
//       testDictionary.Add('c', 3);
//       testDictionary.Add('m', 3);
//       testDictionary.Add('p', 3);
//
//       testDictionary.Add('f', 4);
//       testDictionary.Add('h', 4);
//       testDictionary.Add('v', 4);
//       testDictionary.Add('w', 4);
//       testDictionary.Add('y', 4);
//
//       testDictionary.Add('k', 5);
//
//       testDictionary.Add('j', 6);
//       testDictionary.Add('x', 6);
//
//       testDictionary.Add('q', 7);
//       testDictionary.Add('z', 7);
//
//       int score = 0;
//
//       string lowerInput = input.ToLower();
//       char[] inputArray = lowerInput.ToCharArray();
//       for (int i = 0; i < inputArray.Length; i++) {
//         foreach ( KeyValuePair<char, int> test in testDictionary) {
//           if( inputArray[i] == test.Key)
//           {
//             score += test.Value;
//           }
//         }
//       }
//
//       return score;
//     }
//   }
// }
