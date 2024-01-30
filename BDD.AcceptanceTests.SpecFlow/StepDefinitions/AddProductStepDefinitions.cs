using BDD.API.DataTransferObjects.Internal;
using BDD.API.Models;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD.AcceptanceTests.SpecFlow.StepDefinitions
{
    [Binding]
    public class AddProductStepDefinitions
    {
        private List<Product> products;
        private Product? product;
        private Exception exception;

        public AddProductStepDefinitions()
        {
            GivenTheProjectAPIIsAvailable();
        }

        [Given(@"The product API is available")]
        public void GivenTheProjectAPIIsAvailable()
        {
            products = new List<Product>()
            {
                new Product { Id = 1, Name = "Product One", Price = 100 },
                new Product { Id = 2, Name = "Product Two", Price = 150 }
            };
        }    

        [When(@"the user adds a new product with the following details:")]
        public void WhenTheUserAddsANewProductWithTheFollowingDetails(Table productDetails)
        {
            var productData = productDetails.CreateInstance<Product>();
            products.Add(new Product { Id = products.Count + 1, Name = productData.Name, Price = productData.Price });
        }

        [Then(@"the product should be added successfully")]
        public void ThenTheProductShouldBeAddedSuccessfully()
        {
            product = products.FirstOrDefault(p => p.Id == products.Count);
            product.Should().NotBeNull();
        }

        [When(@"the user attempts to add a new product with the following details:")]
        public void WhenTheUserAttemptsToAddANewProductWithTheFollowingDetails(Table productDetails)
        {
            var productData = productDetails.CreateInstance<Product>();

            try
            {
                if(productData.Price < 1)
                {
                    throw new Exception("Price can't be lesser than 1.");
                }
            }
            catch (Exception ex)
            {
                exception = ex;
            }

        }

        [Then(@"the response should indicate that the input is invalid")]
        public void ThenTheResponseShouldIndicateThatTheInputIsInvalid()
        {
            exception.Should().BeOfType<Exception>();
            exception.Message.Should().Be("Price can't be lesser than 1.");
        }
    }
}
