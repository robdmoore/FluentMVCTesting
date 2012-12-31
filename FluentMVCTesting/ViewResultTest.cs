using System;
using System.Web.Mvc;

namespace FluentMVCTesting
{
    [Obsolete("Please use TestStack.FluentMVCTesting.ViewResultTest")]
    public class ViewResultTest : TestStack.FluentMVCTesting.ViewResultTest
    {
        public ViewResultTest(ViewResultBase viewResult, Controller controller) : base(viewResult, controller) {}
    }
}