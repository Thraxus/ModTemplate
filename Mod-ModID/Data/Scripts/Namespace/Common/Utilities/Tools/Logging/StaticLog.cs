using ModTemplate.Namespace.Common.Enums;
using ModTemplate.Namespace.Settings;
using VRage.Game;
using VRage.Game.Components;
using VRage.Utils;

namespace ModTemplate.Namespace.Common.Utilities.Tools.Logging
{
	[MySessionComponentDescriptor(MyUpdateOrder.NoUpdate, priority: int.MinValue)]
	// ReSharper disable once ClassNeverInstantiated.Global
	internal class StaticLog : MySessionComponentBase
	{
		private const string GeneralLogName = ModSettings.StaticGeneralLogName;
		private const string ExceptionLogName = ModSettings.ExceptionLogName;

		private static Log _generalLog;
		private static Log _exceptionLog;

		private static readonly object GeneralWriteLocker = new object();
		private static readonly object ExceptionWriteLocker = new object();
		
		/// <inheritdoc />
		public override void Init(MyObjectBuilder_SessionComponent sessionComponent)
		{
			base.Init(sessionComponent);
			_exceptionLog = new Log(ExceptionLogName);
			_generalLog = new Log(GeneralLogName);
			WriteToLog("StaticLogger", "Static logs loaded.", LogType.General);
		}

		/// <inheritdoc />
		protected override void UnloadData()
		{
			WriteToLog("StaticLogger", "Closing static logs.", LogType.General);
			lock (ExceptionWriteLocker)
			{
				_exceptionLog?.Close();
			}
			lock (GeneralWriteLocker)
			{
				_generalLog?.Close();
			}
			base.UnloadData();
		}

		public static void WriteToLog(string caller, string message, LogType logType)
		{
			switch (logType)
			{
				case LogType.Exception:
					WriteException(caller, message);
					return;
				case LogType.General:
					WriteGeneral(caller, message);
					return;
				default:
					return;
			}
		}

		private static void WriteException(string caller, string message)
		{
			lock (ExceptionWriteLocker)
			{
				_exceptionLog?.WriteToLog(caller, message);
				MyLog.Default.WriteLine($"{caller}: {message}");
			}
		}

		private static void WriteGeneral(string caller, string message)
		{
			lock (GeneralWriteLocker)
			{
				_generalLog?.WriteToLog(caller, message);
			}
		}
	}
}
