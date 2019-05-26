using Sandbox.ModAPI;

namespace ModTemplate.Namespace.Common.Settings
{
	static class Settings
	{

		#region Constant Values

		public const bool ForcedDebugMode = false;

		public const string SettingsFileName = "ModName-UserConfig.xml";
		public const string StaticGeneralLogName = "StaticLog-General";
		public const string StaticDebugLogName = "StaticLog-Debug";
		public const string ExceptionLogName = "Exception";

		public const ushort NetworkId = 12345;

		#endregion

		#region Reference Values

		public static bool IsServer => MyAPIGateway.Multiplayer.IsServer;

		#endregion


		#region User Configuration

		public static bool DebugMode = false;


		#endregion
	}
}
