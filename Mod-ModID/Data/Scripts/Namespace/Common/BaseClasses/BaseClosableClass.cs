using System;

namespace ModTemplate.Namespace.Common.BaseClasses
{
	public abstract class BaseClosableClass
	{
		public event Action<BaseClosableClass> OnClose;

		private bool _isClosed;

		public virtual void Close()
		{
			if (_isClosed) return;
			_isClosed = true;
			OnClose?.Invoke(this);
		}
	}
}
