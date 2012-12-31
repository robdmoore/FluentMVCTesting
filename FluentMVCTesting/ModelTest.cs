using System;
using System.Web.Mvc;

namespace FluentMVCTesting
{
    [Obsolete("Please use TestStack.FluentMVCTesting.IModelTest<>")]
    public interface IModelTest<TModel> : TestStack.FluentMVCTesting.IModelTest<TModel> {}

    [Obsolete("Please use TestStack.FluentMVCTesting.ModelTest<>")]
    public class ModelTest<TModel> : TestStack.FluentMVCTesting.ModelTest<TModel>, IModelTest<TModel>
    {
        public ModelTest(Controller controller) : base(controller) {}
    }
}