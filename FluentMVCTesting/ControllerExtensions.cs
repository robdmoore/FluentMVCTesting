using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace FluentMVCTesting
{
    public static class ControllerExtensions
    {
        [Obsolete("Please use TestStack.FluentMVCTesting.ControllerExtensions.WithModelErrors")]
        public static T WithModelErrors<T>(this T controller) where T : Controller
        {
            return TestStack.FluentMVCTesting.ControllerExtensions.WithModelErrors(controller);
        }

        [Obsolete("Please use TestStack.FluentMVCTesting package and uninstall the now obsolete FluentMVCTesting package")]
        public static TestStack.FluentMVCTesting.ControllerResultTest<T> WithCallTo<T, TAction>(this T controller, Expression<Func<T, TAction>> actionCall)
            where T : Controller
            where TAction : ActionResult
        {
            return TestStack.FluentMVCTesting.ControllerExtensions.WithCallTo(controller, actionCall);
        }

        [Obsolete("Please use TestStack.FluentMVCTesting.ControllerExtensions.WithCallToChild")]
        public static TestStack.FluentMVCTesting.ControllerResultTest<T> WithCallToChild<T, TAction>(this T controller, Expression<Func<T, TAction>> actionCall)
            where T : Controller
            where TAction : ActionResult
        {
            return TestStack.FluentMVCTesting.ControllerExtensions.WithCallToChild(controller, actionCall);
        }
    }
}
