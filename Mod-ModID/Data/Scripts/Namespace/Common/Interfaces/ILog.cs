using System;

namespace ModTemplate.Mod_ModID.Data.Scripts.Namespace.Common.Interfaces
{
    public interface ILog
    {
        event Action<string, string> OnWriteToLog;
        void WriteGeneral(string caller, string message);
    }
}
