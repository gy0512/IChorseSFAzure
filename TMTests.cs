using IChorse.Helpers;
using IChorse.Pages;
using NUnit.Framework;

namespace IChorse
{
    [TestFixture, Description("This fixture contains Time and Material tests")]
    [Parallelizable]
    class TMTests : SFCommonDriver
    {
        //static void Main(string[] args)
        //{

        //}

        [Test, Order(1), Description("Check if the user is able to create time successfully")]
        public void T1_CreateNewTMTest()
        {
            // Object init and define for home page
            SFHomePage homObj = new SFHomePage();
            homObj.NavigateToTM(driver);

            //Test 1 - To check the time creating.
            // Object init and define for TM page
            SFTMPage tmobj = new SFTMPage();
            tmobj.CreateTM(driver);
        }

    }
}
