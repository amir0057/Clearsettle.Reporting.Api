﻿using System;
using System.Threading.Tasks;
using Clearsettle.Driver.Model.Builder;
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
                TransactionId = "2827-1443515082-3"
            };
            var response = await client.GetTransaction(request);
            response.Should().NotBeNull();
        }
        [TestMethod]
        public async Task Get_Merchanent_Should_Not_Be_Null()
        {
            var request = new MerchentRequest
            {
                TransactionId = "2827-1443515082-3"
            };
            var response = await client.GetMerchant(request);
            response.Should().NotBeNull();
        }
        [TestMethod]
        public async Task Get_Client_Should_Not_Be_Null()
        {
            var request = new ClientRequest
            {
                TransactionId = "2827-1443515082-3"
            };
            var response = await client.GetClient(request);
            response.Should().NotBeNull();
        }

        [TestMethod]
        public async Task Get_TransactionList_Should_Not_Be_Null()
        {
            var request = TransactionListRequestBuilder.Create()
               .FromDate(DateTime.Parse("2014-05-01"))
               .ToDate(DateTime.Parse("2015-10-01"))
               .Build();
           
            var response = await client.GetTransactionList(request);
            response.Should().NotBeNull();
        }

        [TestMethod]
        public async Task Get_Report_Should_Not_Be_Null()
        {
            var request = ReportRequestBuilder.Create()
                .FromDate(DateTime.Parse("2014-05-01"))
                .ToDate(DateTime.Parse("2015-10-01"))
                .Build();
           
            var response = await client.GetReport(request);
            response.Should().NotBeNull();
        }
    }
}