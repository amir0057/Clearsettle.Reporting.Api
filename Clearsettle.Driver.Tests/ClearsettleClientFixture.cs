using System;
using System.Threading.Tasks;
using Clearsettle.Driver.Model.Request;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clearsettle.Driver.Tests
{
    [TestClass]
    public class ClearsettleClientFixture
    {
        private ClearsettleClient client;

        [TestInitialize]
        public void Setup()
        {
            var configuration = new ClearsettleConfiguration
            {
                ApiUrl = "https://testreportingapi.clearsettle.com/api/v3/",
                Email = "demo@bumin.com.tr",
                Password = "cjaiU8CV"
            };
            client = new ClearsettleClient(configuration);
        }

        [TestMethod]
        public async void Login_Should_Not_Be_Null()
        {
            var token = await client.Login();
            token.Should().NotBeNullOrEmpty();
        }

        [TestMethod]
        public async Task Get_Transaction_Should_Not_Be_Null()
        {
            var request = new TransactionRequest
            {
                TransactionId = "1-1444392550-1"
            };
            var response = await client.GetTransaction(request);
            response.Should().NotBeNull();
        }

        public async Task Get_Merchanent_Should_Not_Be_Null()
        {
            var request = new MerchentRequest
            {
                TransactionId = "1-1444392550-1"
            };
            var response = await client.GetMerchant(request);
            response.Should().NotBeNull();
        }

        [TestMethod]
        public async Task Get_TransactionList_Should_Not_Be_Null()
        {
            var request = new TransactionListRequest
            {
                FromDate = DateTime.Parse("2015-07-01"),
                ToDate = DateTime.Parse("2015-10-01")
            };
            var response = await client.GetTransactionList(request);
            response.Should().NotBeNull();
        }

        [TestMethod]
        public async Task Get_Report_Should_Not_Be_Null()
        {
            var request = new ReportRequest
            {
                Acquirer = 1,
                Merchant = 1,
                FromDate = DateTime.Parse("2015-07-01"),
                ToDate = DateTime.Parse("2015-10-01")
            };
            var response = await client.GetReport(request);
            response.Should().NotBeNull();
        }
    }
}