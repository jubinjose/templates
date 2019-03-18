using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebServices.Client.WCFTestServiceReference;

namespace WebServices.Client.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WCFTestServiceClient basicBindingClient = new WCFTestServiceClient("BasicHttpBinding_IWCFTestService");
            var basicResult = basicBindingClient.GetFullName(new Student() { FirstName = "Jubin", LastName = "Joseph" });

            Assert.IsNotNull(basicResult);

            WCFTestServiceClient wsBindingClient = new WCFTestServiceClient("WSHttpBinding_IWCFTestService");
            var wsResult = wsBindingClient.GetFullName(new Student() { FirstName = "Jubin", LastName = "Joseph" });
            Assert.IsNotNull(wsResult);
        }
    }
}
