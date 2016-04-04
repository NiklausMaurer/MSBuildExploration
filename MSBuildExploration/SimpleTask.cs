using System;
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
			Console.Write("This is SimpleTask! Hello, {0}!", this.Name);
			return true;
		}
		#endregion
	}
}