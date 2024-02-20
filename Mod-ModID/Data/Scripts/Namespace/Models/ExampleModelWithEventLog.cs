using Thraxus.Common.BaseClasses;

namespace Thraxus.Models
{
	public class ExampleModelWithEventLog : BaseLoggingClass
	{
		public void ExampleOfClassWritingToOwnersLog()
		{
			WriteGeneral("ExampleOfClassWritingToOwnersLog", "Some Message");
		}
	}
}