using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TestCommon;

using Microsoft.AzureStack.Infra.Admin;
using Microsoft.AzureStack.Infra.Admin.Models;

namespace Infra.Tests
{
    /// <summary>
    /// Summary description for FabricTest
    /// </summary>
    [TestClass]
    public class FabricTest : TestBase
    {
        
        [TestMethod]
        public void TestListInfraRoles()
        {
            RunTest(() => {
                var region = "local";
                var client = Common.CreateAndValidateInfraAdminClient(parameters);
                
                var roles = client.Fabric.ListInfraRoles("local");

                var sb = new System.Text.StringBuilder();
                for(;;) {
                    foreach(var obj in roles) {
                        sb.AppendLine(obj.Name);
                    }
                    if(string.IsNullOrEmpty(roles.NextPageLink)) {
                        break;
                    }
                    roles = client.Fabric.ListInfraRolesNext(roles.NextPageLink);
                }

                System.IO.File.WriteAllText("ListInfraRoles.txt", sb.ToString());
            });
        }
    }
}
