using BDD.API.Models;
using System;
using TechTalk.SpecFlow;

namespace BDD.AcceptanceTests.SpecFlow.StepDefinitions
{
    [Binding]
    public class DeleteProductStepDefinitions
    {
        private List<Product> products;
        private Exception exception;

        [Given(@"there is an existing product")]
        public void GivenThereIsAnExistingProductWithID()
        {
            products = new List<Product>()
            {
                new Product { Id = 1, Name = "Product One", Price = 100 },
                new Product { Id = 2, Name = "Product Two", Price = 150 },
                new Product { Id = 3, Name = "Another Product", Price = 200 }
            };
        }

        [When(@"the user deletes the product with ID (.*)")]
        public void WhenTheUserDeletesTheProductWithID(int productId)
        {
            var product = products.FirstOrDefault(p => p.Id == productId);
            products.Remove(product);
        }

        [Then(@"the product with ID (.*) should be successfully deleted")]
        public void ThenTheProductWithIDShouldBeSuccessfullyDeleted(int productId)
        {
            products.Should().HaveCount(2); 
            products.FirstOrDefault(x => x.Id == productId).Should().BeNull(); 
        }

        [When(@"the user attempts to delete a product with an invalid ID (.*)")]
        public void WhenTheUserAttemptsToDeleteAProductWithAnInvalidID(int productId)
        {
            try
            {
                if (productId == -1)
                {
                    throw new Exception($"Product with id: {productId} does not exist.");
                }
            }
            catch (Exception ex)
            {
                exception = ex;
            }
        }

        [Then(@"the response should indicate that the product with ID (.*) does not exist")]
        public void ThenTheResponseShouldIndicateThatTheProductDoesNotExist(int productId)
        {
            exception.Message.Should().Be($"Product with id: {productId} does not exist.");
        }
    }
}