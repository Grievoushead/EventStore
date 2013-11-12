using System;
using System.Net;

namespace EventStore.ClientAPI
{
    /// <summary>
    /// Event Arguments for the event raised when an <see cref="IEventStoreConnection"/> is 
    /// conncted to an Event Store server.
    /// </summary>
    public class EventStoreConnectedArgs : EventArgs
    {
        /// <summary>
        /// The endpoint of the Event Store server to which the connection was connected.
        /// </summary>
        public IPEndPoint RemoteEndPoint { get; private set; }

        /// <summary>
        /// Constructs a new instance of <see cref="EventStoreConnectedArgs"/>.
        /// </summary>
        /// <param name="remoteEndPoint">The endpoint of the Event Store server to which the connection was connected.</param>
        public EventStoreConnectedArgs(IPEndPoint remoteEndPoint)
        {
            RemoteEndPoint = remoteEndPoint;
        }
    }
}
