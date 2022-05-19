using System;

namespace ModTemplate.Mod_ModID.Data.Scripts.Namespace.Common.Interfaces
{
	public interface ICommon
	{
		event Action<ICommon> OnClose;
		event Action<string, string> OnWriteToLog;

		void Update(ulong tick);

		bool IsClosed { get; }

		void Close();

		void WriteGeneral(string caller, string message);
	}
}
