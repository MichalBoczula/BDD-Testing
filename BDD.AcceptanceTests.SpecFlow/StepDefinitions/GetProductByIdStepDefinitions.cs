using BDD.API.Models;
using System;
using TechTalk.SpecFlow;

namespace BDD.AcceptanceTests.SpecFlow.StepDefinitions
{
    [Binding]
    public class GetProductByIdStepDefinitions
    {
        private List<Product> products;
        private Product? product;

        [Given(@"The product API is available")]
        public void GivenTheProjectAPIIsAvailable()
        {
            //throw new PendingStepException();
        }

        [When(@"the client requests the product by ID")]
        public void WhenTheClientRequestsTheProductWithID() 
        {
            products = new List<Product>()
            {
                new Product { Id = 1, Name = "Product One", Price = 100 },
                new Product { Id = 2, Name = "Product Two", Price = 150 }
            };
        }

        [Then(@"the API should return a product")]
        public void ThenTheAPIShouldReturnAProductWithID()
        {
            product = products.FirstOrDefault(x => x.Id == 1);

            product.Should().NotBeNull();
        }

        [Then(@"the product should have properties id, name, and price")]
        public void ThenTheProductShouldHavePropertiesIdNameAndPrice()
        {
            product.Id.Should().Be(1);
            product.Name.Should().Be("Product One");
            product.Price.Should().Be(100);
        }

        [When(@"the client requests a product with an invalid ID")]
        public void WhenTheClientRequestsAProductWithAnInvalidID()
        {
            products = new List<Product>()
            {
                new Product { Id = 1, Name = "Product One", Price = 100 },
                new Product { Id = 2, Name = "Product Two", Price = 150 }
            };
        }

        [Then(@"the response should indicate that the product with id -1 does not exist")]
        public void ThenTheResponseShouldIndicateThatTheProductDoesNotExist()
        {
            product = products.FirstOrDefault(x => x.Id == -1);

            product.Should().BeNull();
        }
    }
}
