using Microsoft.VisualStudio.TestTools.UnitTesting;

using TestCommon;

namespace Infra.Tests
{
    [TestClass]
    public class ClientTests : TestBase
    {
        
        [TestMethod]
        public void Test1()
        {
            RunTest(() => {
                var client = Common.CreateAndValidateInfraAdminClient(parameters);
            });
        }
    }
}
