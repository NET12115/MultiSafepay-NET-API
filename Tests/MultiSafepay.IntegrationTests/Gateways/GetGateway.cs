﻿using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiSafepay.IntegrationTests.Gateways
{
    [TestClass]
    public class GetGateway
    {
        [TestMethod]
        public void Gateways_GetGateway()
        {
            // Arrange
            var url = ConfigurationManager.AppSettings["MultiSafepayAPI"];
            var apiKey = ConfigurationManager.AppSettings["MultiSafepayAPIKey"];
            var client = new MultiSafepayClient(apiKey, url);

            // Act
            var gateway = client.GetGateway("PayPal");

            // Assert
            Assert.AreEqual("PayPal", gateway.Id);
        }
    }
}
