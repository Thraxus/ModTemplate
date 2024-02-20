using System;

namespace Thraxus.Common.Interfaces
{
    public interface IResetWithEvent<out T> : IReset
    {
        event Action<T> OnReset;
    }
}