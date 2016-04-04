using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSBuildExploration;

namespace MSBuildExplorationTest
{
	[TestClass]
	public class SimpleTaskTest
	{
		#region Properties
		private SimpleTask SimpleTask { get; set; }
		#endregion

		#region Initialize and Cleanup
		[TestInitialize]
		public void InitializeTest()
		{
			this.SimpleTask = new SimpleTask();
		}
		#endregion

		#region Tests
		[TestMethod]
		public void TestExecution()
		{
			// Act
			bool bSuccess = this.SimpleTask.Execute();

			// Assert
			Assert.IsTrue(bSuccess);
		}
		#endregion
	}
}