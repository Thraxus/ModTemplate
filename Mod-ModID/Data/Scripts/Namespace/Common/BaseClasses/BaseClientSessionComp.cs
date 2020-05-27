using ModTemplate.Namespace.Common.Enums;

namespace ModTemplate.Namespace.Common.BaseClasses
{
	public abstract class BaseClientSessionComp : BaseSessionComp
	{
		protected BaseClientSessionComp(string sessionName, bool noUpdate = true) : base(sessionName, SessionCompType.Client, noUpdate) { }
	}
}
