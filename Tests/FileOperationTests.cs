using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presentation;
using Model.FileOperators;
using Ninject;

namespace Tests
{
    [TestClass]
    public class FileOperationTests
    {
        [TestMethod]
        public void ModelTest()
        {
            StandardKernel kernel = new StandardKernel();
            var presenter = new Presenter(kernel);
            kernel.Bind<Model.IPresenter>().ToConstant(presenter);
            kernel.Bind<View.IPresenter>().ToConstant(presenter);
            kernel.Bind<Model.IModel>().ToConstant(new Model.Model(kernel));
            var model = new Model.Model(kernel);
            
            

            Assert.IsTrue(model.operations.Count>0);
        }

       
    }
}
