using Microsoft.Build.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSBuildExploration;
using NSubstitute;

namespace MSBuildExplorationTest
{
    [TestClass]
    public class PostFileTest
    {
        #region Properties
        private PostFile PostFile { get; set; }
        private IBuildEngine BuildEngine { get; set; }
        #endregion

        #region Initialize and Cleanup
        [TestInitialize]
        public void InitializeTest()
        {
            this.BuildEngine = Substitute.For<IBuildEngine>();
            this.PostFile = new PostFile
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
            bool bSuccess = this.PostFile.Execute();

            // Assert
            Assert.IsFalse(this.PostFile.Log.HasLoggedErrors);
            Assert.IsTrue(bSuccess);
        }
        #endregion
    }
}