using ModTemplate.Namespace.Common.Enums;
using VRage.Game;

namespace ModTemplate.Namespace.Common.Interfaces
{
	internal interface ILog
	{
		void WriteToLog(string caller, string message, LogType type, bool showOnHud = false, int duration = Settings.DefaultLocalMessageDisplayTime, string color = MyFontEnum.Green);
	}
}
