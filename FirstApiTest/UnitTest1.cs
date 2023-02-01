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

            // ������ ������
            RestRequest request = new RestRequest("nl/3825", Method.Get);

            // �������� �����
            RestResponse response = client.Execute(request);

            // �������� ���������� ���������� � ����������� (� ������ ������� ��������� ������ ����)
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            // �������� ���������� ���������� � ����������� (� ������ ������ ��������� ��� ������)
            Assert.That(response.ContentType, Is.EqualTo("application/json"));
        }
    }
}