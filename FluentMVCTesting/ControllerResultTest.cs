using System;
using System.Web.Mvc;

namespace FluentMVCTesting
{
    [Obsolete("Please use TestStack.FluentMVCTesting.ControllerResultTest")]
    public class ControllerResultTest<T> : TestStack.FluentMVCTesting.ControllerResultTest<T> where T : Controller
    {
        public ControllerResultTest(T controller, string actionName, ActionResult actionResult) : base(controller, actionName, actionResult) {}
    }
}