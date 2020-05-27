using System;
using ModTemplate.Namespace.Common.Enums;

namespace ModTemplate.Namespace.Common.BaseClasses
{
	public abstract class LogBaseEvent
	{
		public event Action<string, string, LogType> OnWriteToLog;
		private readonly string _id;

		protected LogBaseEvent(string id)
		{
			_id = id;
		}

		protected void WriteToLog(string caller, string message, LogType logType)
		{
			OnWriteToLog?.Invoke($"{_id}: {caller}", message, logType);
		}
	}
}
