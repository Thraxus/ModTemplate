using System;
using System.IO;
using Sandbox.ModAPI;
using VRage;
using VRage.Utils;

namespace ModTemplate.Namespace.Common.Utilities.SaveGame
{
	internal static class SaveToFile
	{
		private const string SaveFileName = "save.eem";

		private static void SaveFile(Type saveData)
		{
			if (MyAPIGateway.Utilities.FileExistsInLocalStorage(SaveFileName, typeof(SaveData)))
				MyAPIGateway.Utilities.DeleteFileInLocalStorage(SaveFileName, typeof(SaveData));

			byte[] save = MyAPIGateway.Utilities.SerializeToBinary(saveData);

			using (BinaryWriter binaryWriter = MyAPIGateway.Utilities.WriteBinaryFileInLocalStorage(SaveFileName, typeof(SaveData)))
			{
				if (binaryWriter == null)
					return;
				binaryWriter.Write(save);
			}
		}
	}
}
