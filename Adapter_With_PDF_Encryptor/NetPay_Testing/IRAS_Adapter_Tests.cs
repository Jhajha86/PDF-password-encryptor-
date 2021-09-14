using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABSS.Adapter.IRAS.API;

namespace NetPay_Testing
{
    [TestClass]
    public class IRAS_Adapter_Tests
    {
        [TestMethod]
        public void ENSURE_POWERPAY_ADAPTER_RECEIVE_RESPONSE_FROM_IRAS()
        {
            //Arrange..
            string irasURL = "https://apisandbox.iras.gov.sg/iras/sb/AISubmission/submit";
            string logFilePath = @"C:\PowerPay\BIN\IRASSubmitLog.txt";
            string ir8aPath = @"C:\PowerPay\BIN\FormIR8A.txt";
            string ir8sPath = @"";
            string a8aPath = @"";
            string a8bPath = @"";
            //  string ir8sPath = @"C:\PowerPay\BIN\FormIR8S.txt";
            // string a8aPath = @"C:\PowerPay\BIN\Appendix8A.txt";
            //  string a8bPath = @"C:\PowerPay\BIN\Appendix8B.txt";
            string userID = "S7244676C";
            string userIDType = "1";

            //Act..
            var submission = new PowerPayAdapter();
            string outputStatus = submission.AISubmit(irasURL,userID, userIDType, "false", "false",logFilePath, ir8aPath, ir8sPath, a8aPath, a8bPath);

            //Assert..
            Assert.AreNotEqual(outputStatus, string.Empty);          
        }

        //May need to write further test cases to ensure the response from IRAS...

        [TestMethod]
        public void TestSetPDFPass()
        {
            //Arrange..
            string password = "1234567890";
            string sourcePath = @"C:\222\222.pdf";
            string destPath   = @"C:\222\SetPassword.pdf";
            //  string ir8sPath = @"C:\PowerPay\BIN\FormIR8S.txt";
            // string a8aPath = @"C:\PowerPay\BIN\Appendix8A.txt";
            //  string a8bPath = @"C:\PowerPay\BIN\Appendix8B.txt";

            //Act..
            var pdf = new PDFEncryptor();
            bool status = pdf.SetPassword(password,sourcePath,destPath);

            //Assert..
            Assert.AreNotEqual(status, false);
        }

    }
}
