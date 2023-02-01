using NUnit.Framework;
using OpenQA.Selenium;
using RestSharp;
using System.Net;

namespace FirstApiTest
{
    [TestFixture]

    public class Tests
    {

        [Test]
        public void Test1()
        {
            // url api
            RestClient client = new RestClient("http://api.zippopotam.us");

            // делаем запрос
            RestRequest request = new RestRequest("nl/3825", Method.Get);

            // получаем ответ
            RestResponse response = client.Execute(request);

            // проверка ожидаемого результата с фактическим (в данном примере проверяем статус кода)
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            // проверка ожидаемого результата с фактическим (в данном случае проверяем тип данных)
            Assert.That(response.ContentType, Is.EqualTo("application/json"));
        }
    }
}