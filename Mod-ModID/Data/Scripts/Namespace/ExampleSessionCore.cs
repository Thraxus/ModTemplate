using ModTemplate.Namespace.Common.BaseClasses;
using ModTemplate.Namespace.Common.Enums;
using ModTemplate.Namespace.Models;
using Sandbox.ModAPI;
using VRage.Game;
using VRage.Game.Components;

namespace ModTemplate.Namespace
{
	[MySessionComponentDescriptor(MyUpdateOrder.BeforeSimulation, priority: int.MinValue + 1)]
	internal class ExampleSessionCore : BaseSessionComp
	{
		protected override string CompName { get; } = "ExampleSessionCore";
		protected override CompType Type { get; } = CompType.Server;
		protected override MyUpdateOrder Schedule { get; } = MyUpdateOrder.NoUpdate;

		// Example of how to use the event driven log (used for classes to write in their owners log)
		private ExampleModelWithEventLog _example;
		
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


			_example = new ExampleModelWithEventLog();
			_example.OnWriteToLog += WriteToLog;
			_example.ExampleOfClassWritingToOwnersLog();
		}

		/// <inheritdoc />
		protected override void Unload()
		{
			_example.OnWriteToLog -= WriteToLog;
			base.Unload();
		}
	}
}