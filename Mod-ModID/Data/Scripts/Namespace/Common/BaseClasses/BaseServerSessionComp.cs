using ModTemplate.Namespace.Common.Enums;

namespace ModTemplate.Namespace.Common.BaseClasses
{
	public abstract class BaseServerSessionComp : BaseSessionComp
	{
		protected BaseServerSessionComp(string sessionName, bool noUpdate = true) : base(sessionName, SessionCompType.Server, noUpdate) { }
	}

}
