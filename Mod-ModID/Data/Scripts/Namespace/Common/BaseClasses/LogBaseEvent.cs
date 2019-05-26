using ModTemplate.Namespace.Common.DataTypes;

namespace ModTemplate.Namespace.Common.BaseClasses
{
	abstract class LogBaseEvent
	{
		public event TriggerLog OnWriteToLog;
		public delegate void TriggerLog(string caller, string message, LogType logType);

		public void WriteToLog(string caller, string message, LogType logType)
		{
			OnWriteToLog?.Invoke(caller, message, logType);
		}
	}
}
