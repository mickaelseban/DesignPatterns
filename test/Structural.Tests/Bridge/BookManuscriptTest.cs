namespace DesignPatterns.Structural.Tests.Bridge
{
    using DesignPatterns.Structural.Bridge;
    using DesignPatterns.Structural.Bridge.Formatters;
    using DesignPatterns.Structural.Bridge.Formatters.Interface;
    using FluentAssertions;
    using System.Linq;
    using System.Text;
    using Xunit;

    [Collection("Structural.Tests")]
    public class BookManuscriptTest
    {
        [Fact]
        public void BookManuscript_ShouldReturnPrintedBook_Reverse()
        {
            // Arrange
            IFormatter formatter = new ReverseFormatter();
            var sut = new Book(formatter, "title-test", "author", "test");

            var print = new StringBuilder();
            print.Append($"Title : {new string("title-test".Reverse().ToArray())}");
            print.Append($"Author : {new string("author".Reverse().ToArray())}");
            print.Append($"Text : {new string("test".Reverse().ToArray())}");
            var expected = print.ToString();

            // Act
            var actual = sut.Print();

            // Assert
            expected.Should().BeEquivalentTo(actual);
        }

        [Fact]
        public void BookManuscript_ShouldReturnPrintedBook_Standard()
        {
            // Arrange
            IFormatter formatter = new StandardFormatter();
            var sut = new Book(formatter, "title-test", "author", "test");

            var print = new StringBuilder();
            print.Append("Title : title-test");
            print.Append("Author : author");
            print.Append("Text : test");
            var expected = print.ToString();

            // Act
            var actual = sut.Print();

            // Assert
            expected.Should().BeEquivalentTo(actual);
        }
    }
}
