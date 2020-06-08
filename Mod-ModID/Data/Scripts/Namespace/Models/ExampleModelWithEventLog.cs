using ModTemplate.Namespace.Common.BaseClasses;
using ModTemplate.Namespace.Common.Enums;

namespace ModTemplate.Namespace.Models
{
	public class ExampleModelWithEventLog : BaseLoggingClass
	{
		protected sealed override string Id { get; } = "ExampleModelWithEventLog"; // If only we could use reflection!

		public void ExampleOfClassWritingToOwnersLog()
		{
			WriteToLog("ExampleOfClassWritingToOwnersLog", "Some Message", LogType.General);
		}
	}
}