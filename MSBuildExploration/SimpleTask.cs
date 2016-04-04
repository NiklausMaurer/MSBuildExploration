using System;
using Microsoft.Build.Utilities;

namespace MSBuildExploration
{
    public class SimpleTask : Task
    {
	    public override bool Execute()
	    {
			Console.Write("This is SimpleTask!");
		    return true;
	    }
    }

}
