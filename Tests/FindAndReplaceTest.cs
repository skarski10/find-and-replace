using System;
using Xunit;
using System.Collections.Generic;
using FindAndReplaceApp.Objects;

namespace FindAndReplaceAppTest
{
    public class FindAndReplaceTest
    {
        [Fact]
        public void FindAndReplace_Constructor_Result()
        {
            // Arrange
            string userInput = "Hello world";
            string word1 = "world";
            string word2 = "universe";
            // Act
            FindAndReplace newFindAndReplace = new FindAndReplace(userInput, word1, word2);

            // Assert
            Assert.Equal(userInput, newFindAndReplace.GetUserString());
            Assert.Equal(word1, newFindAndReplace.GetFindWord());
            Assert.Equal(word2, newFindAndReplace.GetReplaceWord());
        }

        [Fact]
        public void LocateFindWord_FindTheWord_True()
        {
            // Arrange
            string userInput = "Hello world";
            string word1 = "world";
            string word2 = "universe";

            // Act
            FindAndReplace newFindAndReplace = new FindAndReplace(userInput, word1, word2);

            // Assert
            Assert.Equal(true, newFindAndReplace.LocateFindWord());
        }

        [Fact]
        public void ReplaceFindWord_ReplaceTheFindeWord_ReplaceWord()
        {
            // Arrange
            string userInput = "Hello world";
            string word1 = "world";
            string word2 = "universe";
            string expectedResults = "Hello universe";

            // Act
            FindAndReplace newFindAndReplace = new FindAndReplace(userInput, word1, word2);


            // Assert
            Assert.Equal(expectedResults, newFindAndReplace.ReplaceFindWord());
        }
    }
}
