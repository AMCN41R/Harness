﻿using Harness.Attributes;
using Xunit;

namespace Harness.Examples.XUnit
{
    [HarnessConfig(ConfigFilePath = "ExampleSettings.json")]
    public class UsingTheBaseClass : HarnessBase
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var classUnderTest = new ClassUnderTest();

            // Act
            var result = classUnderTest.GetCollectionRecordCount("TestCollection1");

            // Assert
            Assert.Equal(2, result);

        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var classUnderTest = new ClassUnderTest();
            var mongoClient = base.MongoConnections["mongodb://localhost:20719"];

            // Act
            var result = classUnderTest.GetCollectionRecordCount(mongoClient, "TestCollection1");

            // Assert
            Assert.Equal(2, result);

        }

    }

}
