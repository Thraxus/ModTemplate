using ModTemplate.Mod_ModID.Data.Scripts.Namespace.Common.BaseClasses;
using ModTemplate.Mod_ModID.Data.Scripts.Namespace.Common.Enums;
using ModTemplate.Mod_ModID.Data.Scripts.Namespace.Models;
using Sandbox.ModAPI;
using VRage.Game;
using VRage.Game.Components;

namespace ModTemplate.Mod_ModID.Data.Scripts.Namespace
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
			WriteGeneral("LateSetup", $"Cargo: {MyAPIGateway.Session.SessionSettings.CargoShipsEnabled}");
			WriteGeneral("LateSetup", $"Encounters: {MyAPIGateway.Session.SessionSettings.EnableEncounters}");
			WriteGeneral("LateSetup", $"Drones: {MyAPIGateway.Session.SessionSettings.EnableDrones}");
			WriteGeneral("LateSetup", $"Scripts: {MyAPIGateway.Session.SessionSettings.EnableIngameScripts}");
			WriteGeneral("LateSetup", $"Sync: {MyAPIGateway.Session.SessionSettings.SyncDistance}");
			WriteGeneral("LateSetup", $"View: {MyAPIGateway.Session.SessionSettings.ViewDistance}");
			WriteGeneral("LateSetup", $"PiratePCU: {MyAPIGateway.Session.SessionSettings.PiratePCU}");
			WriteGeneral("LateSetup", $"TotalPCU: {MyAPIGateway.Session.SessionSettings.TotalPCU}");
			foreach (MyObjectBuilder_Checkpoint.ModItem mod in MyAPIGateway.Session.Mods)
				WriteGeneral("LateSetup", $"Mod: {mod}");


			_example = new ExampleModelWithEventLog();
			_example.OnWriteToLog += WriteGeneral;
			_example.ExampleOfClassWritingToOwnersLog();
		}

		/// <inheritdoc />
		protected override void Unload()
		{
			_example.OnWriteToLog -= WriteGeneral;
			base.Unload();
		}
	}
}