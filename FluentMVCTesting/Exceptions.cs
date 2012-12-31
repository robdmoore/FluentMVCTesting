using System;

namespace FluentMVCTesting
{
    [Obsolete("Please use TestStack.FluentMVCTesting.ActionResultAssertionException instead")]
    public class ActionResultAssertionException : TestStack.FluentMVCTesting.ActionResultAssertionException
    {
        public ActionResultAssertionException(string message) : base(message) { }
    }

    [Obsolete("Please use TestStack.FluentMVCTesting.ViewResultModelAssertionException instead")]
    public class ViewResultModelAssertionException : TestStack.FluentMVCTesting.ViewResultModelAssertionException
    {
        public ViewResultModelAssertionException(string message) : base(message) { }
    }

    [Obsolete("Please use TestStack.FluentMVCTesting.ModelErrorAssertionException instead")]
    public class ModelErrorAssertionException : TestStack.FluentMVCTesting.ModelErrorAssertionException
    {
        public ModelErrorAssertionException(string message) : base(message) { }
    }

    [Obsolete("Please use TestStack.FluentMVCTesting.InvalidControllerActionException instead")]
    public class InvalidControllerActionException : TestStack.FluentMVCTesting.InvalidControllerActionException
    {
        public InvalidControllerActionException(string message) : base(message) { }
    }
}
