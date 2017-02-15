using System;
using Xunit;
using System.Collections.Generic;
using FindAndReplaceApp.Objects;

namespace FindAndReplaceAppTest
{
    public class FindAndReplaceTest
    {
        [Fact]
        public void FirstTestMethod_Functionality_Result()
        {
            // Arrange
            string userInput = "Hello world";
            // Act
            FindAndReplace newFindAndReplace = new FindAndReplace(userInput);

            // Assert
            Assert.Equal(userInput, newFindAndReplace.GetUserString());
        }
    }
}
