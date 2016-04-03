
using FluentAssertions;
using Newtonsoft.Json.Linq;
using NUnit.Core;
using NUnit.Framework;
using RestSharp;

namespace AnythingCanBeDone.specs.services.product
{
    public class ProductTests : ServiceBase
    {

        [Test]
        [Category("Services")]
        public void GetProducts(int productNumber)
        {
            var client = new RestClient("http://localhost");
            var request = new RestRequest("api/products/2", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            // validate the response stauts
            response.ResponseStatus.Should().Be(ResponseStatus.Completed);
            // validate the response body key name
            JsonInstance.ParseJson(content).GetValue("Name").ToString().Should().Contain("Yo-yo");
        }

        [Test]
        [Category("Services")]
        public void GetCountries()
        {
            var client = new RestClient("http://api.worldbank.org");
            var request = new RestRequest("countries?format=json", Method.GET);
            IRestResponse response = client.Execute(request);
            // validate the response stauts
            response.ResponseStatus.Should().Be(ResponseStatus.Completed);
            JArray countries = JArray.Parse(response.Content);
            countries[0]["total"].ToString().Should().Be("264");
        }
    }
}
