using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace MSBuildExploration
{
	public class SimpleTask : Task
	{
		#region Properties
		public string Name { get; set; }
		#endregion

		#region Publics
		public override bool Execute()
		{
			Log.LogMessage(MessageImportance.Normal, "This is SimpleTask! Hello, {0}!", this.Name);
			return true;
		}
		#endregion
	}
}