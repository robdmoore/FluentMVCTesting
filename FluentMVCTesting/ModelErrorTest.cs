using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FluentMVCTesting
{
    [Obsolete("Please use TestStack.FluentMVCTesting.IModelErrorTest<>")]
    public interface IModelErrorTest<TModel> : TestStack.FluentMVCTesting.IModelErrorTest<TModel> {}

    [Obsolete("Please use TestStack.FluentMVCTesting.ModelErrorTest<>")]
    public class ModelErrorTest<TModel> : TestStack.FluentMVCTesting.ModelErrorTest<TModel>, IModelErrorTest<TModel>
    {
        public ModelErrorTest(TestStack.FluentMVCTesting.IModelTest<TModel> modelTest, string errorKey, IEnumerable<ModelError> errors) : base(modelTest, errorKey, errors) {}
    }
}