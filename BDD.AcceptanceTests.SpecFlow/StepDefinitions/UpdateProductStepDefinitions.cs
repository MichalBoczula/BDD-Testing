using BDD.API.DataTransferObjects.Internal;
using BDD.API.Models;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD.AcceptanceTests.SpecFlow.StepDefinitions
{
    [Binding]
    public class UpdateProductStepDefinitions
    {
        private List<Product> products;
        private Exception exception;

        public UpdateProductStepDefinitions()
        {
            products = new List<Product>()
            {
                new Product { Id = 1, Name = "Product One", Price = 100 },
                new Product { Id = 2, Name = "Product Two", Price = 150 },
                new Product { Id = 3, Name = "Another Product", Price = 200 }
            };
        }

        [When(@"the user updates the product with ID (.*) with the following details:")]
        public void WhenTheUserUpdatesTheProductWithIDWithTheFollowingDetails(int productId, Table productDetails)
        {
            var productData = productDetails.CreateInstance<Product>();
            var idx = products.FindIndex(x => x.Id == productId);

            products[idx].Name = productData.Name;
            products[idx].Price = productData.Price;
        }

        [Then(@"the product with ID (.*) should be updated with the new details:")]
        public void ThenTheProductWithIDShouldBeUpdatedWithTheNewDetails(int productId, Table productDetails)
        {
            var productData = productDetails.CreateInstance<Product>();
            var product = products.FirstOrDefault(x => x.Id == productId);

            product.Price.Should().Be(productData.Price);
            product.Name.Should().Be(productData.Name);
        }

        [When(@"the user attempts to update a product with an invalid ID (.*)")]
        public void WhenTheUserAttemptsToUpdateAProductWithAnInvalidID(int productId)
        {
            try
            {
                if (productId == -11)
                {
                    throw new Exception($"Product with id: {productId} does not exist.");
                }
            }
            catch (Exception ex)
            {
                exception = ex;
            }
        }

        [Then(@"the response should indicate that there is no product with ID (.*)")]
        public void ThenTheAPIShouldReturnANotFoundStatusCode(int productId)
        {
            exception.Message.Should().Be($"Product with id: {productId} does not exist.");
        }
    }
}
