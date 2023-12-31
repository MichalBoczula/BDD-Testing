using BDD.API.Models;
using System;
using TechTalk.SpecFlow;

namespace BDD.AcceptanceTests.SpecFlow.StepDefinitions
{
    [Binding]
    public class GetProductsStepDefinitions
    {
        List<Product> products;

        [Given(@"the project API is available")]
        public void GivenTheProjectAPIIsAvailable()
        {
            //throw new PendingStepException();
        }

        [When(@"the client requests the list of projects")]
        public void WhenTheClientRequestsTheListOfProjects()
        {
            products = new List<Product>()
            {
                new Product { Id = 1, Name = "Product One", Price = 100 },
                new Product { Id = 2, Name = "Product Two", Price = 150 },
                new Product { Id = 3, Name = "Another Product", Price = 200 }
            };
        }

        [Then(@"the API should return a list of projects")]
        public void ThenTheAPIShouldReturnAListOfProjects()
        {
            products.Should().HaveCount(3);
        }

        [Then(@"each project should have properties id, name, and price")]
        public void ThenEachProjectShouldHavePropertiesIdNameAndPrice()
        {
            products.ForEach(x =>
            {
                x.Id.Should().NotBe(0);
                x.Id.Should().NotBe(null);

                x.Name.Should().NotBeNullOrWhiteSpace();

                x.Price.Should().NotBe(0);
                x.Price.Should().NotBe(null);
            });
        }
    }
}
