using Microsoft.Build.Utilities;

namespace MSBuildExploration
{
    public class SimpleTask : Task
    {
	    public override bool Execute()
	    {
		    return true;
	    }
    }

}
