using ModTemplate.Mod_ModID.Data.Scripts.Namespace.Common.BaseClasses;

namespace ModTemplate.Mod_ModID.Data.Scripts.Namespace.Models
{
	public class ExampleModelWithEventLog : BaseLoggingClass
	{
		public void ExampleOfClassWritingToOwnersLog()
		{
			WriteGeneral("ExampleOfClassWritingToOwnersLog", "Some Message");
		}
	}
}