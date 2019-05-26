using ModTemplate.Namespace.Utilities.Networking.Messages;
using ProtoBuf;
using Sandbox.ModAPI;

namespace ModTemplate.Namespace.Utilities.Networking
{
	[ProtoInclude(10, typeof(ExampleMessage))]
	[ProtoContract]
	public abstract class MessageBase
	{
		[ProtoMember(1)] protected readonly ulong SenderId;

		protected MessageBase()
		{
			SenderId = MyAPIGateway.Multiplayer.MyId;
		}

		public abstract void HandleServer();

		public abstract void HandleClient();
	}
}
