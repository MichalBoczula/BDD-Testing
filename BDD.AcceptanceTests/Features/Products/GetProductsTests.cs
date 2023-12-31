using BDD.AcceptanceTests.Common;
using BDD.AcceptanceTests.Configuration;
using BDD.API.DataTransferObjects.Internal;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.AcceptanceTests.Features.Products
{
    public class GetProductsTests : IClassFixture<WebAppFactory<Program>>
    {
        private readonly HttpClient _client;

        public GetProductsTests(WebAppFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ShouldReturnList()
        {
            //arrange & act
            var response = await _client.GetAsync("/Products");

            //assert
            response.EnsureSuccessStatusCode();
            var result = await Utilities.GetResponseContent<List<ProductDto>>(response);
            result.Should().HaveCount(4);
            result.ForEach(x =>
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
