using System;
using WebApplication.Models;
using Xunit;

namespace WebApplication.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            // Arrange 
            var product = new Product { Name = "Mrowka", Price = 100 };
            // Act
            product.Name = "Mrowka";
            //Assert
            Assert.Equal("Mrowka", product.Name);
        }


        [Fact]
        public void Test2()
        {

            // Arrange 
            var product = new Product { Name = "Mrowka", Price = 100 };
            // Act
            product.Price = 100;
            //Assert
            Assert.Equal(100, product.Price);
        }

        [Fact]
        public void Test3()
        {

            // Arrange 
            var product = new Product { Name = "Mrowka", Price = 100, Category="Zwierze" };
            // Act
            product.Category = "Zwierze";
            //Assert
            Assert.Equal("Zwierze", product.Category);
        }

    }
}
