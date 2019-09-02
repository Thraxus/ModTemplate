using System;
using System.IO;
using Sandbox.ModAPI;

namespace ModTemplate.Namespace.Common.Utilities.SaveGame
{
	internal class Load
	{
		public static T ReadFromFile<T>(string fileName, Type type)
		{
			if (!MyAPIGateway.Utilities.FileExistsInWorldStorage(fileName, type))
				return default(T);

			using (BinaryReader binaryReader = MyAPIGateway.Utilities.ReadBinaryFileInWorldStorage(fileName, type))
			{
				return MyAPIGateway.Utilities.SerializeFromBinary<T>(binaryReader.ReadBytes(binaryReader.ReadInt32()));
			}
		}

		public static T ReadFromSandbox<T>(string fileName, Type type)
		{
			return default(T);
		}

	}
}
