using Microsoft.Build.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSBuildExploration;
using NSubstitute;

namespace MSBuildExplorationTest
{
	[TestClass]
	public class SimpleTaskTest
	{
		#region Constants
		private const string MICHAEL_JACKSON = "Michael Jackson";
		#endregion

		#region Properties
		private SimpleTask SimpleTask { get; set; }
		private IBuildEngine BuildEngine { get; set; }
		#endregion

		#region Initialize and Cleanup
		[TestInitialize]
		public void InitializeTest()
		{
			this.BuildEngine = Substitute.For<IBuildEngine>();
			this.SimpleTask = new SimpleTask
			                  {
				                  BuildEngine = this.BuildEngine
			                  };
		}
		#endregion

		#region Tests
		[TestMethod]
		public void TestExecution()
		{
			// Arrange
			this.SimpleTask.Name = MICHAEL_JACKSON;

			// Act
			bool bSuccess = this.SimpleTask.Execute();

			// Assert
			Assert.IsFalse(this.SimpleTask.Log.HasLoggedErrors);
			this.BuildEngine.Received().LogMessageEvent(Arg.Is<BuildMessageEventArgs>(args => args.Message.Contains(MICHAEL_JACKSON)));
			Assert.IsTrue(bSuccess);
		}
		#endregion
	}
}