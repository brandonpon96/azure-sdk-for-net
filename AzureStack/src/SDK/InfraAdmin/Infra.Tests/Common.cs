using Microsoft.Rest.Azure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Text;
using System.Collections.Generic;

using Microsoft.AzureStack.Infra.Admin;
using TestCommon;

namespace Infra.Tests
{
    class Common
    {
        public static InfraAdminClient CreateAndValidateInfraAdminClient(TestCommon.TestingParameters parameters)
        {
            // Create client using parametes from file
            var client = new InfraAdminClient(parameters.BaseUri, TestCommon.Authentification.GetCredentials(parameters)) {
                SubscriptionId = parameters.SubscriptionId
            };

            // validate creation
            Assert.IsNotNull(client);

            // validate objects
            Assert.IsNotNull(client.Alerts);
            Assert.IsNotNull(client.Storage);
            Assert.IsNotNull(client.Locations);
            Assert.IsNotNull(client.Pools);
            Assert.IsNotNull(client.InfraRoles);
            Assert.IsNotNull(client.Updates);

            // validate properties
            Assert.AreEqual(parameters.SubscriptionId, client.SubscriptionId);

            return client;
        }
        
    }
}
