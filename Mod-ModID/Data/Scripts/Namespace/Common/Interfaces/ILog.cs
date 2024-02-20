﻿using System;

namespace Thraxus.Common.Interfaces
{
    public interface ILog : IClose
    {
        event Action<string, string> OnWriteToLog;
        void WriteGeneral(string caller, string message);
    }
}
