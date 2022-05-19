using ModTemplate.Mod_ModID.Data.Scripts.Namespace.Common.BaseClasses;
using ModTemplate.Mod_ModID.Data.Scripts.Namespace.Common.Utilities.FileHandlers;
using VRage.Game.ModAPI.Ingame.Utilities;

namespace ModTemplate.Mod_ModID.Data.Scripts.Namespace.Settings.MyCustomIni
{
	public class ImportCustomUserSettings : BaseLoggingClass
	{
		private static readonly MyIni MyIni = new MyIni();
		private string _customUserIni;
		private bool _customConfigSet;

		public void Run()
		{
			if (_customConfigSet) return;
			_customConfigSet = true;

			_customUserIni = Load.ReadFileInWorldStorage<ImportCustomUserSettings>(ModSettings.MyIniFileName);
			if (string.IsNullOrEmpty(_customUserIni))
			{
				WriteGeneral("GetCustomUserIni", "No custom settings found. Exporting vanilla settings.");
				ExportDefaultUserSettings.Run();
				return;
			}
			if (!MyIni.TryParse(_customUserIni))
			{
                WriteGeneral("GetCustomUserIni", "Parse failed for custom user settings. Exporting vanilla settings.");
				ExportDefaultUserSettings.Run();
				return;
			}
			if (!MyIni.ContainsSection(ConfigConstants.SectionName))
			{
                WriteGeneral("GetCustomUserIni", "User config did not contain the proper section. Exporting vanilla settings.");
				ExportDefaultUserSettings.Run();
				return;
			}
			ParseConfig();
		}

		private static void ParseConfig()
		{
			UserSettings.MyIniSettingBoolExample = MyIni.Get(ConfigConstants.SectionName, IniSupport.MyIniSettingBoolExampleName).ToBoolean(UserSettings.MyIniSettingBoolExample);
			UserSettings.MyIniSettingIntExample = MyIni.Get(ConfigConstants.SectionName, IniSupport.MyIniSettingIntExampleName).ToBoolean(UserSettings.MyIniSettingIntExample);
		}
	}
}