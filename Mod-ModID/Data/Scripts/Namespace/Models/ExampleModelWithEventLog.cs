using ModTemplate.Namespace.Common.BaseClasses;
using ModTemplate.Namespace.Common.Enums;

namespace ModTemplate.Namespace.Models
{
	public class ExampleModelWithEventLog : LogBaseEvent
	{
		private const string ModelName = "ExampleModelWithEventLog"; // If only we could use reflection!
		public ExampleModelWithEventLog() : base(ModelName) { }

		public void ExampleOfClassWritingToOwnersLog()
		{
			WriteToLog("ExampleOfClassWritingToOwnersLog", "Some Message", LogType.General);
		}
	}
}