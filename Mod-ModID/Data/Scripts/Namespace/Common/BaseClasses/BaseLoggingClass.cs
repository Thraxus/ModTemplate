using System;
using ModTemplate.Mod_ModID.Data.Scripts.Namespace.Common.Interfaces;

namespace ModTemplate.Mod_ModID.Data.Scripts.Namespace.Common.BaseClasses
{
	public abstract class BaseLoggingClass : ICommon
	{
		public event Action<string, string> OnWriteToLog;
		public event Action<ICommon> OnClose;

		public bool IsClosed { get; private set; }

		public virtual void Close()
		{
			if (IsClosed) return;
			IsClosed = true;
			OnClose?.Invoke(this);
		}

		public virtual void Update(ulong tick) { }

		public virtual void WriteGeneral(string caller, string message)
		{
			OnWriteToLog?.Invoke(caller, message);
		}
	}
}