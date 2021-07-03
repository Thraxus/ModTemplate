using ModTemplate.Data.Scripts.Namespace.Common.BaseClasses;
using ModTemplate.Data.Scripts.Namespace.Common.Enums;

namespace ModTemplate.Data.Scripts.Namespace.Models
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