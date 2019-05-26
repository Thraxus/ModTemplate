using ModTemplate.Namespace.Common.BaseClasses;
using ModTemplate.Namespace.Common.DataTypes;
using Sandbox.ModAPI;
using VRage.Game;

namespace ModTemplate.Namespace
{
	class ExampleSessionCore : BaseServerSessionComp
	{
		private const string GeneralLogName = "CoreGeneral";
		private const string DebugLogName = "CoreDebug";
		private const string SessionCompName = "Core";

		public ExampleSessionCore() : base(GeneralLogName, DebugLogName, SessionCompName) { } // Do nothing else

		/// <inheritdoc />
		protected override void EarlySetup()
		{
			base.EarlySetup();
		}

		/// <inheritdoc />
		protected override void LateSetup()
		{
			base.LateSetup();
			WriteToLog("LateSetup", $"Cargo: {MyAPIGateway.Session.SessionSettings.CargoShipsEnabled}", LogType.General);
			WriteToLog("LateSetup", $"Encounters: {MyAPIGateway.Session.SessionSettings.EnableEncounters}", LogType.General);
			WriteToLog("LateSetup", $"Drones: {MyAPIGateway.Session.SessionSettings.EnableDrones}", LogType.General);
			WriteToLog("LateSetup", $"Scripts: {MyAPIGateway.Session.SessionSettings.EnableIngameScripts}", LogType.General);
			WriteToLog("LateSetup", $"Sync: {MyAPIGateway.Session.SessionSettings.SyncDistance}", LogType.General);
			WriteToLog("LateSetup", $"View: {MyAPIGateway.Session.SessionSettings.ViewDistance}", LogType.General);
			WriteToLog("LateSetup", $"PiratePCU: {MyAPIGateway.Session.SessionSettings.PiratePCU}", LogType.General);
			WriteToLog("LateSetup", $"TotalPCU: {MyAPIGateway.Session.SessionSettings.TotalPCU}", LogType.General);
			foreach (MyObjectBuilder_Checkpoint.ModItem mod in MyAPIGateway.Session.Mods)
				WriteToLog("LateSetup", $"Mod: {mod}", LogType.General);
		}

		/// <inheritdoc />
		protected override void Unload()
		{
			base.Unload();
		}
	}
}
