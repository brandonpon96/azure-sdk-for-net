using Microsoft.VisualStudio.TestTools.UnitTesting;

using TestCommon;

using Microsoft.AzureStack.Infra.Admin;
using Microsoft.AzureStack.Infra.Admin.Models;

namespace Infra.Tests
{
    [TestClass]
    public class AlertTests : TestBase
    {

        [TestMethod]
        public void AlertList()
        {
            RunTest(() => {
                var region = "local";
                var client = Common.CreateAndValidateInfraAdminClient(parameters);


                var list = client.Alerts.List(region);

                var sb = new System.Text.StringBuilder();
                while (!string.IsNullOrEmpty(list.NextPageLink)) {
                    foreach (var obj in list) {
                        sb.Append(obj);
                    }
                }
                System.IO.File.WriteAllText("derp.txt", sb.ToString());
            });
        }
    }
}
