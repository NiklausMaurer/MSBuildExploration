using Microsoft.Build.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSBuildExploration;
using NSubstitute;

namespace MSBuildExplorationTest
{
    [TestClass]
    public class PushToTestStoreTaskTest
    {
        #region Properties
        private PushToTestStoreTask PushToTestStoreTask { get; set; }
        private IBuildEngine BuildEngine { get; set; }
        #endregion

        #region Initialize and Cleanup
        [TestInitialize]
        public void InitializeTest()
        {
            this.BuildEngine = Substitute.For<IBuildEngine>();
            this.PushToTestStoreTask = new PushToTestStoreTask
            {
                BuildEngine = this.BuildEngine
            };
        }
        #endregion

        #region Tests
        [TestMethod]
        public void TestExecution()
        {
            // Act
            bool bSuccess = this.PushToTestStoreTask.Execute();

            // Assert
            Assert.IsFalse(this.PushToTestStoreTask.Log.HasLoggedErrors);
            Assert.IsTrue(bSuccess);
        }
        #endregion
    }
}