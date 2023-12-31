using BDD.AcceptanceTests.Configuration;

namespace BDD.AcceptanceTests.Features.Products.GetProducts
{
    public class UnitTest1 : IClassFixture<WebAppFactory<Program>>
    {
        private readonly HttpClient _client;

        public UnitTest1(WebAppFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }
     
        [Fact]
        public void Test1()
        {
            Assert.False(false);
        }
    }
}