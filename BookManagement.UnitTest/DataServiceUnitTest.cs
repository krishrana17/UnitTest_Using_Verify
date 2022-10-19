using System;
using System.Collections.Generic;
using Xunit;
using Shouldly;
using BookManagement.DataService;
using BookManagement.DataService.Models;

namespace BookManagement.UnitTest
{
    public class DataServiceUnitTest
    {
        [Fact]
        public void GetBookById_ShouldReturnSingleBook_WhenIdFound()
        {
            // Arrange
            var bookId = new Guid("C71AE620-CA18-4897-853B-C988A92375F9");
            var sut = new TechnicalBookProvider();

            //Act
            var result = sut.GetBookById(bookId);

            //Assert
            result.ShouldBeOfType<Book>();
            result.Id.ShouldBe(bookId);
            result.BookName.ShouldBe("The Pragmatic Programmer");
            result.Publisher.ShouldBe("Addison Wesley");
        }

        [Fact]
        public void GetAllBooks_ShouldReturnAllBook_WhenExists()
        {
            // Arrange
            var sut = new TechnicalBookProvider();

            //Act
            var result = sut.GetAllBooks();

            //Assert
            result.ShouldBeOfType<List<Book>>();
            result.ShouldNotBeNull();
            result.Count.ShouldBe(2);
        }
    }
}
