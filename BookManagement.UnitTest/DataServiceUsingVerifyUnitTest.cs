using System;
using System.Threading.Tasks;
using Xunit;
using BookManagement.DataService;
using BookManagement.DataService.Models;
using VerifyTests;
using VerifyXunit;

namespace BookManagement.UnitTest
{
    [UsesVerify]
    public class DataServiceUsingVerifyUnitTest
    {
        [Fact]
        public async Task GetBookById_ShouldReturnSingleBook_WhenItFound()
        {
            // Arrange
            var bookId = new Guid("C71AE620-CA18-4897-853B-C988A92375F9");
            var setting = new VerifySettings();
            setting.IgnoreMember<Book>(book => book.Publisher);
            var sut = new TechnicalBookProvider();

            //Act
            var result = sut.GetBookById(bookId);

            //Assert
            await Verifier.Verify(result, setting);
        }
    }
}
